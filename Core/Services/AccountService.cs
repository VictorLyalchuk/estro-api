using AutoMapper;
using Core.DTOs.Token;
using Core.DTOs.User;
using Core.Entities.DashBoard;
using Core.Helpers;
using Core.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;

namespace Core.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<User> _userManager;
        private readonly EmailService _emailService;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private readonly IImageService _image;
        private readonly IWebHostEnvironment _env;

        public AccountService(UserManager<User> userManager, IConfiguration configuration, IMapper mapper, IImageService image, EmailService emailService, IWebHostEnvironment env)
        {
            _userManager = userManager;
            _configuration = configuration;
            _mapper = mapper;
            _image = image;
            _emailService = emailService;
            _env = env;
        }
        public async Task<UserDTO> Get(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user != null)
            {
                return _mapper.Map<UserDTO>(user);
            }
            else
                throw new CustomHttpException(ErrorMessages.UserNotFoundById, HttpStatusCode.NotFound);
        }
        public async Task<string> Login(UserLoginDTO loginDTO)
        {
            var user = await _userManager.FindByNameAsync(loginDTO.Email);
            var pass = await _userManager.CheckPasswordAsync(user, loginDTO.Password);
            if (user == null)
            {
                throw new CustomHttpException(ErrorMessages.UserNotFoundById, HttpStatusCode.BadRequest);
            }
            if (user == null || !pass)
            {
                throw new CustomHttpException(ErrorMessages.ErrorLoginorPassword, HttpStatusCode.BadRequest);
            }

            var currentRole = (await _userManager.GetRolesAsync(user)).FirstOrDefault();
            var claimsList = new List<Claim>()
            {
                new Claim("Email", loginDTO.Email),
                new Claim("FirstName", user.FirstName),
                new Claim("LastName", user.LastName),
                new Claim("ImagePath", user.ImagePath),
                new Claim("Role", currentRole!),
                new Claim("Id", user.Id),
            };
            if (!string.IsNullOrEmpty(user.PhoneNumber))
            {
                claimsList.Add(new Claim("PhoneNumber", user.PhoneNumber));
            }
            var jwtOptions = _configuration.GetSection("Jwt").Get<JwtOptions>();
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOptions!.Key));
            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: jwtOptions.Issuer,
                claims: claimsList,
                expires: DateTime.Now.AddMinutes(jwtOptions.LifeTime),
                signingCredentials: signinCredentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        public async Task Registration(UserRegistrationDTO registrationDTO)
        {
            User user = _mapper.Map<User>(registrationDTO);
            user.UserName = registrationDTO.Email;

            if(registrationDTO.ImageFile != null)
            {
                user.ImagePath = await _image.CreateUserImageAsync(registrationDTO.ImageFile);
            }
            var result = await _userManager.CreateAsync(user, registrationDTO.Password);

            await SendConfirmationEmailAsync(registrationDTO.Email);

            await _userManager.AddToRoleAsync(user, registrationDTO.Role);
            
            if (!result.Succeeded)
            {
                var messageError = string.Join(",", result.Errors.Select(er => er.Description));
                throw new CustomHttpException(messageError, System.Net.HttpStatusCode.BadRequest);
            }
        }
        public async Task Edit(UserEditDTO editDTO)
        {
            var user = await _userManager.FindByEmailAsync(editDTO.Email);
            var pass = await _userManager.CheckPasswordAsync(user, editDTO.Password);

            if (user == null || !pass)
            {
                throw new CustomHttpException(ErrorMessages.ErrorLoginorPassword, HttpStatusCode.BadRequest);
            }
            if (user.Email != editDTO.Email)
            {
                user.EmailConfirmed = false;
                var confirmationResut = await _userManager.UpdateAsync(user);
            }
            if (user != null)
            {
                User updatedUser = _mapper.Map<User>(user);
                updatedUser.UserName = editDTO.Email;
                updatedUser.Email = editDTO.Email;
                updatedUser.FirstName = editDTO.FirstName;
                updatedUser.LastName = editDTO.LastName;
                updatedUser.PhoneNumber = editDTO.PhoneNumber;
                updatedUser.ImagePath = editDTO.ImagePath;
                updatedUser.Birthday = editDTO.Birthday;
                var result = await _userManager.UpdateAsync(updatedUser);
            }
        }
        public async Task DeleteUserImage(string email)
        {

            var user = await _userManager.FindByEmailAsync(email);
            if (user != null)
            {
                user.ImagePath = "";
                await _userManager.UpdateAsync(user);

            }
        }
        public async Task EditUserImageAsync(ImageUserEditDTO editDTO)
        {
            var user = await _userManager.FindByEmailAsync(editDTO.Email);
            if (user != null)
            {
                User updatedUser = _mapper.Map<User>(user);
                updatedUser.ImagePath = editDTO.ImagePath;
                var result = await _userManager.UpdateAsync(updatedUser);
            }
        }
        public async Task ForgotPasswordAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                throw new CustomHttpException(ErrorMessages.ErrorLoginorPassword, HttpStatusCode.BadRequest);
            }
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var encodedToken = Encoding.UTF8.GetBytes(token);
            var validEmailToken = WebEncoders.Base64UrlEncode(encodedToken);

            string templateFilePath = Path.Combine(_env.WebRootPath, "email", "ForgotPasswordTemplate.html");
            string emailBody = File.ReadAllText(templateFilePath);

            string url = $"{_configuration["HostSettings:URL"]}/auth/{email}/{validEmailToken}";

            emailBody = emailBody.Replace("{url}", url);

            await _emailService.SendEmailAsync(email, "Reset password", emailBody);
        }
        public async Task ResetPasswordAsync(ResetPasswordDTO model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                throw new CustomHttpException(ErrorMessages.ErrorLoginorPassword, HttpStatusCode.BadRequest);
            }
            var decodedToken = WebEncoders.Base64UrlDecode(model.Token);
            string normalToken = Encoding.UTF8.GetString(decodedToken);

            try
            {
                var result = await _userManager.ResetPasswordAsync(user, normalToken, model.NewPassword);
                if (!result.Succeeded)
                {
                    throw new CustomHttpException("Failed to reset password", HttpStatusCode.BadRequest);
                }
            }
            catch (Exception ex)
            {
                throw new CustomHttpException($"Error resetting password: {ex.Message}", HttpStatusCode.InternalServerError);
            }

        }
        public async Task SendConfirmationEmailAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                throw new CustomHttpException(ErrorMessages.ErrorLoginorPassword, HttpStatusCode.BadRequest);
            }
            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var encodedToken = Encoding.UTF8.GetBytes(token);
            var validEmailToken = WebEncoders.Base64UrlEncode(encodedToken);

            string templateFilePath = Path.Combine(_env.WebRootPath, "email", "ConfirmationEmailTemplate.html");
            string emailBody = File.ReadAllText(templateFilePath);

            string url = $"{_configuration["HostSettings:URL"]}/account/settings/{email}/{validEmailToken}";
            
            emailBody = emailBody.Replace("{url}", url);

            await _emailService.SendEmailAsync(email!, "Email confirmation", emailBody);
        }
        public async Task ConfirmEmailAsync(ConfirmEmailDTO model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                throw new CustomHttpException(ErrorMessages.ErrorLoginorPassword, HttpStatusCode.BadRequest);
            }
            var decodedToken = WebEncoders.Base64UrlDecode(model.Token);
            string normalToken = Encoding.UTF8.GetString(decodedToken);
            try
            {
                var result = await _userManager.ConfirmEmailAsync(user, normalToken);
                if (!result.Succeeded)
                {
                    throw new CustomHttpException("Failed to confirm your email", HttpStatusCode.BadRequest);
                }
            }
            catch (Exception ex)
            {
                throw new CustomHttpException($"Error confirm email: {ex.Message}", HttpStatusCode.InternalServerError);
            }
        }
        public async Task RefreshTokenAsync(TokenRequestDto model)
        {
            //var result = await _jwtService.VerifyTokenAsync(model);
            //return result;
        }

    }
}

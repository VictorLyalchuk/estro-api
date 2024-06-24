using Core.DTOs.User;
using Core.Entities.UserEntity;
using Core.Services;
using Microsoft.AspNetCore.Identity;


namespace Core.Interfaces
{
    public interface IAccountService
    {
        Task<UserDTO> GetByEmail(string email);
        Task<UserDTO> GetByPhone(string phone);
        Task<string> SendSMS(string phone);
        Task<string> Login(UserLoginDTO loginDTO);
        Task<LoginByPhoneResultDTO> LoginByPhone(string phone);
        Task Registration(UserRegistrationDTO registrationDTO);
        Task Edit(UserEditDTO editDTO);
        Task DeleteUserImage(string email);
        Task EditUserImageAsync(ImageUserEditDTO editDTO);
        Task ForgotPasswordAsync(string email);
        Task ResetPasswordAsync(ResetPasswordDTO model);
        Task SendConfirmationEmailAsync(string email);
        Task ConfirmEmailAsync(ConfirmEmailDTO model);
        Task ConfirmEmailAsync(string email);
        Task<string> RefreshTokenAsync(string oldToken);
    }
}

using Core.DTOs.User;
using Core.Helpers;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountControllers : Controller
    {
        private readonly IAccountService _accountService;

        public AccountControllers(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpGet("{email}")]
        public async Task<IActionResult> Get([FromRoute] string email)
        {
            try
            {
                var user = await _accountService.GetByEmail(email);
                if (user == null)
                {
                    return NotFound();
                }
                return Ok(user);
            }
            catch (CustomHttpException ex)
            {
                return NotFound();
            }
        }
        [HttpGet("GetByPhone")]
        public async Task<IActionResult> GetByPhone(string phone)
        {
            try
            {
                var user = await _accountService.GetByPhone(phone);
                if (user == null)
                {
                    return NotFound();
                }
                return Ok(user);
            }
            catch (CustomHttpException ex)
            {
                return NotFound();
            }
        }
        [HttpPost("SendSMS")]
        public async Task<IActionResult> SendSMS(string phone)
        {
            try
            {
                var result = await _accountService.SendSMS(phone);
                return Ok(new { VerificationSid = result });
            }
            catch (CustomHttpException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserLoginDTO loginDTO)
        {
            var token = await _accountService.Login(loginDTO);
            return Ok(new { token });
        }
        [HttpPost("LoginByPhone")]
        public async Task<IActionResult> LoginByPhone(string phone)
        {
            var token = await _accountService.LoginByPhone(phone);
            return Ok(new { token });
        }
        [HttpPost("Registration")]
        public async Task<IActionResult> Registration(UserRegistrationDTO registrationDTO)
        {
            await _accountService.Registration(registrationDTO);
            return Ok();
        }
      
        [HttpPost("Edit")]
        public async Task<IActionResult> Edit(UserEditDTO editDTO)
        {
            await _accountService.Edit(editDTO);
            return Ok();
        }
        [HttpPost("DeleteUserImage")]
        public async Task<IActionResult> DeleteUserImageAsync([FromForm] string email)
        {
            await _accountService.DeleteUserImage(email);
            return Ok();
        }
        [HttpPost("EditUserImage")]
        public async Task<IActionResult> EditUserImageAsync(ImageUserEditDTO editDTO)
        {
            await _accountService.EditUserImageAsync(editDTO);
            return Ok();
        }

        [HttpPost("ForgotPassword")]
        public async Task<IActionResult> ForgotPassword([FromBody] string email)
        {
            try
            {
                await _accountService.ForgotPasswordAsync(email);
                return Ok();
            }
            catch (CustomHttpException ex)
            {
                return NotFound();
            }
        }
        [HttpPost("ResetPassword")]
        public async Task<IActionResult> ResetPassword(ResetPasswordDTO model)
        {
            try
            {
                await _accountService.ResetPasswordAsync(model);
                return Ok();
            }
            catch (CustomHttpException ex)
            {
                return NotFound();
            }
        }
        [HttpPost("ConfirmEmail")]
        public async Task<IActionResult> ConfirmEmail(ConfirmEmailDTO model)
        {
            try
            {
                await _accountService.ConfirmEmailAsync(model);
                return Ok();
            }
            catch (CustomHttpException ex)
            {
                return NotFound();
            }
        }
    }
}

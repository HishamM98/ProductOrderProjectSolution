using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracticeProject.Core.Domain.IdentityEntities;
using PracticeProject.Core.DTO.AccountDTOs;
using PracticeProject.Core.ServiceContracts;

namespace PracticeProject.WebAPI.Controllers.v1
{
    /// <summary>
    /// Account Controller to handle different account endpoints
    /// </summary>
    /// <param name="userManager"></param>
    /// <param name="signInManager"></param>
    /// <param name="jwtService"></param>
    [ApiVersion("1.0")]
    //[Route("api/v{version:apiVersion}/[controller]")]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AccountsController(UserManager<User> userManager, SignInManager<User> signInManager, IJwtService jwtService) : ControllerBase
    {
        private readonly UserManager<User> _userManager = userManager;
        private readonly SignInManager<User> _signInManager = signInManager;
        private readonly IJwtService _jwtService = jwtService;

        /// <summary>
        /// Logs the user in using email and password
        /// </summary>
        /// <param name="login">login request that includes user's email and password</param>
        /// <returns>authentication response including user's jwt token</returns>
        [HttpPost("[action]")]
        public async Task<IActionResult> Login([FromBody] LoginRequest login)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await _userManager.Users.SingleOrDefaultAsync(x => x.Email == login.Email);

            if (user == null) return Unauthorized("Invalid Email/Password");

            var result = await _signInManager.CheckPasswordSignInAsync(user, login.Password, false);

            if (!result.Succeeded) return Unauthorized("Username not found and/or password incorrect");

            var tokenRes = _jwtService.CreateJwtToken(user);

            var response = user.ToAuthResponse();
            response.Token = tokenRes.Token;
            response.Expiration = tokenRes.Expiration;
            return Ok(response);

        }

        /// <summary>
        /// Registers new user
        /// </summary>
        /// <param name="register">register request that includes user's data</param>
        /// <returns>authentication response including user's jwt token</returns>
        [HttpPost("[action]")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest register)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var user = register.ToUser();
                var createdUser = await _userManager.CreateAsync(user, register.Password);

                if (createdUser.Succeeded)
                {
                    var applyRole = await _userManager.AddToRoleAsync(user, "User");

                    if (applyRole.Succeeded)
                    {
                        var authResponse = _jwtService.CreateJwtToken(user);

                        user.RefreshToken = authResponse.RefreshToken ?? "";
                        user.RefreshTokenExpirationDateTime = authResponse.RefreshTokenExpirationDateTime;

                        await _userManager.UpdateAsync(user);

                        return Ok(authResponse);
                    }
                    else
                    {
                        return StatusCode(500, applyRole.Errors);
                    }
                }
                else
                {
                    return StatusCode(500, createdUser.Errors);
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}

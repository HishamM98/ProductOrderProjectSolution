using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PracticeProject.Core.Domain.IdentityEntities;

namespace PracticeProject.WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AccountController(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<UserRole> roleManager) : ControllerBase
    {
        private readonly UserManager<User> _userManager = userManager;
        private readonly SignInManager<User> _signInManager = signInManager;
        private readonly RoleManager<UserRole> _roleManager = roleManager;

        [HttpPost("[action]")]
        public IActionResult Login()
        {

        }

    }
}

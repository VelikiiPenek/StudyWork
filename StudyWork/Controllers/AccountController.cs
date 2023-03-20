using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace StudyWork.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService) 
        { 
            _accountService = accountService;
        }

        [HttpGet]

        public IActionResult Register() => View();


        [HttpGet]
        public async Task<IAccountResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var response = await _accountService.Register(model);
                if (response.StatusCode == Domain.Enum.StatusCode.OK)
                {
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, 
                        new ClaimsPrincipal)
                }
            }
        }




        public IActionResult Index()
        {
            return View();
        }



    }
}

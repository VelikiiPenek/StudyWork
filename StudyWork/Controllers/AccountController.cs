using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Org.BouncyCastle.Crypto.Engines;
using System.Reflection.Metadata.Ecma335;

namespace StudyWork.Controllers
{
    public class AccountController : Controller
    {
        //private readonly IAccountService _accountService;

        //public AccountController(IAccountService accountService) 
        //{ 
        //    _accountService = accountService;
        //}

        //[HttpGet]

        //public IActionResult Register() => View();


        //[HttpGet]
        //public async Task<IAccountResult> Register(RegisterViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var response = await _accountService.Register(model);
        //        if (response.StatusCode == Domain.Enum.StatusCode.OK)
        //        {
        //            await HttpContext.SignInAsync(CookieAuthenticationDefaults.Authentic  ationScheme,
        //                new ClaimsPrincipal(response.Data));

        //            return RedirectToAction("Index", "Home");
        //        }
        //        ModelState.TryAddModelError("", response.Description);
        //    }
        //    return View(model);
        //}

        //[HttpGet]

        //public IActionResult Login() => View();

        //[HttpPost] 

        //public async Task <IActionResult> Login(LoginViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var response = await _accountService.Login(model);
        //        if (response.StatusCode == Domain.Enum.StatusCode.OK)
        //        {
        //            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
        //                new ClaimsPrincipal(response.Data));


        //            return RedirectToAction("Index", "Home");
        //        }
        //        ModelState.AddModelError("", response.Description);
        //    }
        //    return View(model);
        //}


        //[ValidateAntiForgeryToken]

        //public async Task<IActionResult> Logout()
        //{
        //    await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        //    return RedirectToAction("Index", "Home");
                
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}



    }
}

    using Microsoft.AspNetCore.Mvc;
using StudyWork.Models;

namespace StudyWork.Controllers
{
    public class AuthorizationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Check(Authorization authorization)
        //{
        //    if ( )
        //}
    }
}

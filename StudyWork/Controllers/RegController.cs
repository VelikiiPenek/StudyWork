using Microsoft.AspNetCore.Mvc;
using StudyWork.Models;

namespace StudyWork.Controllers
{
    public class RegController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Check(Registration registration)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        return Redirect("/");
        //    }
        //    return View("Index");


        //}
    }
}

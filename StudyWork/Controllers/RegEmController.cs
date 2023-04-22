using Microsoft.AspNetCore.Mvc;

namespace StudyWork.Controllers
{
    public class RegEmController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Check()
        {
            return View();
        }

    }
}

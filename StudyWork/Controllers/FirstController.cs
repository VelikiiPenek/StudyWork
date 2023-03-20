using Microsoft.AspNetCore.Mvc;

namespace StudyWork.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

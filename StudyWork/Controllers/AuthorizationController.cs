using Microsoft.AspNetCore.Mvc;

namespace StudyWork.Controllers
{
    public class AuthorizationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

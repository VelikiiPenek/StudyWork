using Microsoft.AspNetCore.Mvc;
using StudyWork.Models;

namespace StudyWork.Controllers
{
    public class StudyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(Study study)
        {
            if (ModelState.IsValid)
            {
                return Redirect("/");
            }
            return View("Index");
        }
    }
}

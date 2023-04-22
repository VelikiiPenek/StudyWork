using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudyWork.Controllers
{
    public class AddStudController : Controller
    {
        // GET: AddStudController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AddStudController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AddStudController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddStudController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AddStudController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AddStudController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AddStudController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AddStudController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

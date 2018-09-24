using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace IsmekCrm.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Action()
        {
            return View("Olay");
        }

        public ActionResult Veri()
        {
            TimeSpan saat = DateTime.Now.TimeOfDay;
            return View(saat);
        }

        public ActionResult Tarih()
        {
            return View("Date", DateTime.Now.Date);
        }
    }
}

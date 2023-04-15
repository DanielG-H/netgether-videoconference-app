using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VideoconferenceApp.Database;
using VideoconferenceApp.Models;

namespace VideoconferenceApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly DatabaseContext _databaseContext;

        public HomeController(DatabaseContext databaseContext) { _databaseContext = databaseContext; }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SignUp(User obj)
        {
            if (obj.Username == obj.Password)
            {
                ModelState.AddModelError("password", "The Password cannot be the same as Username");
            }

            User? user = _databaseContext.Users.FirstOrDefault(u => u.Username == obj.Username);
            if (user != null)
            {
                ModelState.AddModelError("username", "Username already exists please choose another one");
            }

            if (ModelState.IsValid)
            {
                _databaseContext.Users.Add(obj);
                _databaseContext.SaveChanges();
                return RedirectToAction("Index", "Room");
            }
            return View(obj);
        }

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SignIn(User obj)
        {
            User? user = _databaseContext.Users.FirstOrDefault(u => u.Username == obj.Username && u.Password == obj.Password);
            if (user != null)
            {
                return RedirectToAction("Index", "Room");
            }
            return View(obj);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
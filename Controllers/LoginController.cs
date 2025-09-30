using Microsoft.AspNetCore.Mvc;

namespace tuti.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(String email, string password)
        {

            if (email == "admin123@gmail.com" && password == "admin123")
            {
                return RedirectToAction("Dashboard", "Home");
            }
            ViewBag.Erorr = "Username dan Password salah!";
            return View();
        }
    }
}

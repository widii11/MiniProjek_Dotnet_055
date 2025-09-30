using Microsoft.AspNetCore.Mvc;

namespace tuti.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}

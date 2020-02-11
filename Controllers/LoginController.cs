using Microsoft.AspNetCore.Mvc;

namespace Program.Controllers
{
    public class LoginController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}
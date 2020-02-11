using Microsoft.AspNetCore.Mvc;

namespace Program.Controllers
{
    public class RegistrationController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace Program.Controllers
{
    public class CartsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}
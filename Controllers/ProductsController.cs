using Microsoft.AspNetCore.Mvc;

namespace Program.Controllers
{
    public class ProductsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}
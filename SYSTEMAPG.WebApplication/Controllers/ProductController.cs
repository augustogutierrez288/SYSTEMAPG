using Microsoft.AspNetCore.Mvc;

namespace SYSTEMAPG.WebApplication.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

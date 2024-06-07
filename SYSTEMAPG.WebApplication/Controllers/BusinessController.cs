using Microsoft.AspNetCore.Mvc;

namespace SYSTEMAPG.WebApplication.Controllers
{
    public class BusinessController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

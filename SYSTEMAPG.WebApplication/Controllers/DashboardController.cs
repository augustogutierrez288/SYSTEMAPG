using Microsoft.AspNetCore.Mvc;

namespace SYSTEMAPG.WebApplication.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

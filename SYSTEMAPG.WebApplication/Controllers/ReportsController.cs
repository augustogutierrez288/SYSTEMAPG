using Microsoft.AspNetCore.Mvc;

namespace SYSTEMAPG.WebApplication.Controllers
{
    public class ReportsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

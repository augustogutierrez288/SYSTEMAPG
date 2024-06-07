using Microsoft.AspNetCore.Mvc;

namespace SYSTEMAPG.WebApplication.Controllers
{
    public class SalesHistoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace SYSTEMAPG.WebApplication.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

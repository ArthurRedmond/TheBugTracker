using Microsoft.AspNetCore.Mvc;

namespace TheBugTracker.Controllers
{
    public class UserRolesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

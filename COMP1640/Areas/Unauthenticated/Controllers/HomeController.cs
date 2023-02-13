using Microsoft.AspNetCore.Mvc;

namespace COMP1640.Areas.Unauthenticated.Controllers
{
    [Area("Unauthenticated")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

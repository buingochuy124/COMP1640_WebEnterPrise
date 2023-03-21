using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace COMP1640.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize("RequireAdmin")]
    public class AssignRoleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

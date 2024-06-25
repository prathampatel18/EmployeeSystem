using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

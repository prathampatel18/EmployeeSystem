using EmployeeSystem.BusinessEntity;
using EmployeeSystem.BusinessService;
using EmployeeSystem.BusinessService.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View(_userService.GetUser());
        }

        public IActionResult AddUser(int? id)
        {
            if (id.HasValue)
            {

                ViewData["Form Title"] = "Edit user";

                string d1 = Convert.ToString(ViewData["Form Title"]);

                return View(_userService.GetUser(id.Value));
            }

            ViewData["FormTitle"] = "Add User";
            return View();
        }

        [HttpPost]
        public IActionResult AddUser(UserViewModel user)
        {
            TempData["Message"] = user.EmpId > 0 ? "User updated successfully" : "User save Successfully!";

            var p = _userService.AddEditUser(user);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteUser(int id)
        {
            var p = _userService.DeleteUser(id);    
            return RedirectToAction("Index","User");
        }
       

    }
}

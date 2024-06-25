using EmployeeSystem.BusinessEntity;
using EmployeeSystem.BusinessService.Interface;
using Microsoft.AspNetCore.Mvc;
using NuGet.Versioning;

namespace EmployeeSystem.Controllers
{
    public class UserInfoController : Controller
    {
        private readonly IUserService _userService;
        public UserInfoController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult Data()
        {
            var p = _userService.GetUser();

            return Json(new { data = p });
        }

        public PartialViewResult AddEditForm(int? id)
        {
            if (id.HasValue)
            {
                var d = _userService.GetUser(id.Value);
                return PartialView( d);
            }

            return PartialView();
        }

        [HttpPost]
        public JsonResult AddUser(UserViewModel user)
        {
            var p = _userService.AddEditUser(user);
            return Json(new {result = p,message = "User Saved Successfully!"});
        }

        [HttpPost]
        public JsonResult DeleteInfo(int id)
        {
            var p = _userService.DeleteUser(id);
            return Json(new { result = p, message = "User Deleted Successfully!" });
        }
    }

}

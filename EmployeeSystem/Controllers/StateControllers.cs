using Microsoft.AspNetCore.Mvc;
using EmployeeSystem.Repository.Concreate;
using EmployeeSystem.Repository.Repository;
using EmployeeSystem.BusinessService.Concreate;
using EmployeeSystem.BusinessService.Interface;


namespace EmployeeSystem.Controllers
{
    public class StateControllers : Controller
    {
        private readonly IStateService stateService;

        public StateControllers()
        {
            stateService = new StateService();
        }

        
        public IActionResult Index()
        {
            return View(stateService.GetState());
        }
    }
}

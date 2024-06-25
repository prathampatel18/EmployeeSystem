using Microsoft.AspNetCore.Mvc;
using EmployeeSystem.Repository.Concreate;
using EmployeeSystem.Repository.Repository;
using EmployeeSystem.BusinessService.Concreate;
using EmployeeSystem.BusinessService.Interface;


namespace EmployeeSystem.Controllers
{
    public class StateControllers : Controller
    {
        private readonly IStateService _stateService;

        public StateControllers(IStateService stateService)
        {
            _stateService =  new StateService();
        }

        
        public IActionResult StateDetail()
        {
           return View(_stateService.GetState());
        }
        public IActionResult Index()
        {
            return View(_stateService.GetState());
        }


    }
}

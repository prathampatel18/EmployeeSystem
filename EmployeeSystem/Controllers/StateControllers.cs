using EmployeeSystem.Repository.Concreate;
using EmployeeSystem.Repository.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.Controllers
{
    public class StateControllers : Controller
    {
        private readonly IStateDetailRepository stateDetailRepository;

        public StateControllers()
        {
            stateDetailRepository = new StateDetailRepository();
        }

        public IActionResult StateDetail()
        {
            return View(stateDetailRepository.GetStateDetails());
        }

        public IActionResult Index()
        {
            return View(stateDetailRepository.GetStateDetails());
        }
    }
}

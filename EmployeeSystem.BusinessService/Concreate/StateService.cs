using EmployeeSystem.BusinessService.Interface;
using EmployeeSystem.Common;
using EmployeeSystem.Repository.Concreate;
using EmployeeSystem.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeSystem.BusinessEntity;

namespace EmployeeSystem.BusinessService.Concreate
{
    public class StateService : IStateService
    {
        private readonly IStateDetailRepository _staterepo;

        public StateService()
        {
            _staterepo = new StateDetailRepository();
        }



        List<StateViewModel> IStateService.GetState()
        {
            var d = _staterepo.GetStateDetails();
            return d.ToViewModel();
        }

        StateViewModel IStateService.GetState(int id)
        {
            var d = _staterepo.GetStateDetail(id);
            return d.ToViewModel();
        }
    }
}

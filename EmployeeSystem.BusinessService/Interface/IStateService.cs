using EmployeeSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeSystem.BusinessEntity;

namespace EmployeeSystem.BusinessService.Interface
{
    public interface IStateService
    {
        List<StateViewModel> GetState();

        StateViewModel GetState(int id);  
        
    }
}

using EmployeeSystem.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.Repository.Repository
{
    public interface IStateDetailRepository
    {
        List<StateDetail> GetStateDetails();

        StateDetail GetStateDetail(int id); 
    }
}

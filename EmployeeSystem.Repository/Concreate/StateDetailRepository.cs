using EmployeeSystem.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeSystem.DataEntity;
using EmployeeSystem.Repository.Repository;

namespace EmployeeSystem.Repository.Concreate
{
    public class StateDetailRepository : IStateDetailRepository
    {
        private readonly EmployeeDbContext context;

        public StateDetailRepository()
        {
            context = new EmployeeDbContext();
        }

    
       public StateDetail GetStateDetail(int id)
        {
            return context.StateDetails.Find(id);
        }



        public List<StateDetail> GetStateDetails()
        {
            return context.StateDetails.ToList();
        }
    }
}

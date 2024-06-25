using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.Repository
{
    public interface IGenericRepository<P> where P : class
    {
        IEnumerable<P> GetAll();
        P GetById(int id);
        void Insert(P obj); 
        void Update(P obj);
        void Delete(object id);
    }
}

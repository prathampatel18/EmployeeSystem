using EmployeeSystem.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.Repository.Repository
{
    public interface IUserRepository
    {
        List<Employeedetail> GetUser();

        Employeedetail GetUser(int id);


        bool AddEditUser(Employeedetail employeedetail);

        bool DeleteUser(int id);
    }
}

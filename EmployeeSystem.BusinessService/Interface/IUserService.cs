using EmployeeSystem.BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.BusinessService.Interface
{
    public interface IUserService
    {
        List<UserViewModel> GetUser();

        UserViewModel GetUser(int id);

        bool AddEditUser(UserViewModel user);

        bool DeleteUser(int id);
    }
}

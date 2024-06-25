using EmployeeSystem.BusinessService.Concreate;
using EmployeeSystem.BusinessService.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.BusinessService
{
    public static class ServiceDepedencyContainer
    {
        public static void Registration(IServiceCollection serviceCollectiopn)
        {

            serviceCollectiopn.AddScoped<IUserService, UserService>();
        }
    }
}

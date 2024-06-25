using EmployeeSystem.Repository.Concreate;
using EmployeeSystem.Repository.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeSystem.Repository
{
    public static class RepositoryDepedencyContainer
    {
        public static void Registration(IServiceCollection serviceCollectiopn)
        {


            serviceCollectiopn.AddScoped<IUserRepository, UserRepository>();
        }
    }
}

using AutoMapper;
using EmployeeSystem.BusinessEntity;
using EmployeeSystem.DataEntity;

namespace EmployeeSystem.Mapping
{
    public class AutomapperRegistration : Profile
    {
        public AutomapperRegistration()
        {

            CreateMap<Employeedetail, UserViewModel>().ReverseMap();
        }
    }
}   

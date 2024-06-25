using EmployeeSystem.BusinessService.Interface;
using EmployeeSystem.Common;
using EmployeeSystem.Repository.Concreate;
using EmployeeSystem.Repository.Repository;
using EmployeeSystem.BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata;
using AutoMapper;
using EmployeeSystem.DataEntity;

namespace EmployeeSystem.BusinessService.Concreate
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userrepo;

        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        { 
            _userrepo =  userRepository;
            _mapper = mapper;
        }

        public bool AddEditUser(UserViewModel user)
        {
            //  return _userrepo.AddEditUser(employeedetail.ToDataEntity());
            var p = _mapper.Map<Employeedetail>(user);
            return _userrepo.AddEditUser(p);
        }

        public bool DeleteUser(int id)
        {
            return _userrepo.DeleteUser(id);

        }

        public List<UserViewModel> GetUser()
        {
            var d = _userrepo.GetUser();
            return _mapper.Map<List<UserViewModel>>(d);
        }

        public UserViewModel GetUser(int id)
        {
            var d = _userrepo.GetUser(id);   
            return _mapper.Map<UserViewModel>(d);
        }

    }
}

using EmployeeSystem.DataEntity;
using EmployeeSystem.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.Repository.Concreate
{
    public class UserRepository : IUserRepository
    {
        private readonly EmployeeDbContext context;

        public UserRepository()
        {
            context = new();
        }   

        public bool AddEditUser(Employeedetail employeedetail)
        {
            if (employeedetail.EmpId > 0)
            {
                var d = context.Employeedetails.Find(employeedetail.EmpId);
                d.Fname = employeedetail.Fname;
                d.Lname = employeedetail.Lname;
                d.Contact = employeedetail.Contact;


            }
            else
            {
                context.Employeedetails.Add(employeedetail);
            }

            return context.SaveChanges() > 0 ? true : false;
        }

        public bool DeleteUser(int id)
        {
            var d = context.Employeedetails.Find(id);
            context.Employeedetails.Remove(d);
            return context.SaveChanges() > 0 ? true : false;
        }

        public List<Employeedetail> GetUser()
        {
            return context.Employeedetails.ToList();
        }

        public Employeedetail GetUser(int id)
        {
            return context.Employeedetails.Find(id);
        }
    }
}

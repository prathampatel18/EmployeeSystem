using EmployeeSystem.BusinessEntity;
using EmployeeSystem.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.Common
{
    static public class Helper
    {
        public static StateViewModel ToViewModel(this StateDetail statedetails)
        {
            return new StateViewModel
            {
                StateName = statedetails.StateName,
                StateId = statedetails.StateId

            };
        }

        public static List<StateViewModel> ToViewModel(this List<StateDetail> stateDetails)
        {
            return stateDetails.Select(x => ToViewModel(x)).ToList();
        }

        public static UserViewModel ToViewModel(this Employeedetail employeedetail)
        {
            return new UserViewModel
            {
                EmpId = employeedetail.EmpId,
                FName = employeedetail.Fname,
                LName = employeedetail.Lname,
                Contact = employeedetail.Contact
               
            };
        }

        public static List<UserViewModel> ToViewModel(this List<Employeedetail> employees)
        {
            return employees.Select(x => ToViewModel(x)).ToList();
        }

        public static Employeedetail ToDataEntity(this UserViewModel user)
        {
            Employeedetail employeedetail1 = new Employeedetail();

            employeedetail1.EmpId = user.EmpId;
            employeedetail1.Fname = user.FName;
            employeedetail1.Lname = user.LName;
            employeedetail1.Contact= user.Contact;

            return employeedetail1;
        }
    }
}

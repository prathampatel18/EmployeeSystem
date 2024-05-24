using EmployeeSystem.BusinessEntity;
using EmployeeSystem.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return stateDetails.Select(x =>ToViewModel(x)).ToList();
        }
    }
}

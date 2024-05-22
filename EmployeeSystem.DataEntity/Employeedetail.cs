using System;
using System.Collections.Generic;

namespace EmployeeSystem.DataEntity;

public partial class Employeedetail
{
    public int EmpId { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? Gender { get; set; }

    public int? Age { get; set; }

    public string? Email { get; set; }

    public string? Contact { get; set; }

    public DateTime? Dob { get; set; }

    public int? StateId { get; set; }

    public int? CityId { get; set; }

    public bool? IsActive { get; set; }
}

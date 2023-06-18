using System;
using System.Collections.Generic;

namespace EmployeesBackend;

public partial class Employee
{
    public long Id { get; set; }

    public string EmployeeId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;
}

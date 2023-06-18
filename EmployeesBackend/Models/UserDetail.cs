using System;
using System.Collections.Generic;

namespace EmployeesBackend;

public partial class UserDetail
{
    public long Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

}

using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class EmployeePayTbl
{
    public string EmplD { get; set; } = null!;

    public short? Position { get; set; }

    public DateOnly? DateHire { get; set; }

    public int? Salary { get; set; }

    public int? Bonus { get; set; }

    public int EmpPid { get; set; }

    public virtual EmployeeTbl EmplDNavigation { get; set; } = null!;
}

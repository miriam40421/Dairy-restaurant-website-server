using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class EmployeeTbl
{
    public string EmpId { get; set; } = null!;

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? Zip { get; set; }

    public string? Phone { get; set; }

    public string? Addresss { get; set; }

    public string? City { get; set; }

    public virtual ICollection<EmployeePayTbl> EmployeePayTbls { get; set; } = new List<EmployeePayTbl>();
}

using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class CustumerTbl
{
    public string CustId { get; set; } = null!;

    public string? CustName { get; set; }

    public string? CustPhone { get; set; }

    public string? CustEmail { get; set; }

    public DateTime DateOfBirth { get; set; }
}

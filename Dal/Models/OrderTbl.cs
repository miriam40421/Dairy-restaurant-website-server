using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class OrderTbl
{
    public short Ordnum { get; set; }

    public string CustId { get; set; } = null!;

    public DateTime OrdDate { get; set; }

    public double? Sum { get; set; }

    public bool? Ispaid { get; set; }

    public virtual ICollection<DetailsTbl> DetailsTbls { get; set; } = new List<DetailsTbl>();
}

using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class DetailsTbl
{
    public int Id { get; set; }

    public short? Ordnum { get; set; }

    public int? ProdId { get; set; }

    public int? Qty { get; set; }

    public virtual OrderTbl? OrdnumNavigation { get; set; }

    public virtual ProductsTbl? Prod { get; set; }
}

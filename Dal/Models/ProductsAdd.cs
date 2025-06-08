using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class ProductsAdd
{
    public int ProdAddId { get; set; }

    public int? CatId { get; set; }

    public string? ProdAddDesc { get; set; }

    public int? Cost { get; set; }

    public virtual CategoryTbl? Cat { get; set; }
}

using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class ProductsTbl
{
    public int ProdId { get; set; }

    public int? CatId { get; set; }

    public string? ProdDesc { get; set; }

    public int? Cost { get; set; }

    public string? Name { get; set; }

    public string? Img { get; set; }

    public DateOnly? LastDateUpdate { get; set; }

    public short? Oty { get; set; }

    public virtual CategoryTbl? Cat { get; set; }

    public virtual ICollection<DetailsTbl> DetailsTbls { get; set; } = new List<DetailsTbl>();
}

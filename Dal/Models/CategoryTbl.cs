using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class CategoryTbl
{
    public int CatId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<ProductsAdd> ProductsAdds { get; set; } = new List<ProductsAdd>();

    public virtual ICollection<ProductsTbl> ProductsTbls { get; set; } = new List<ProductsTbl>();
}

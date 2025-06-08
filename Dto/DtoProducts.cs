
namespace Dto
{
    public class DtoProducts
    {
        public int? ProdId { get; set; }

        public string CatName { get; set; }
        public int? CatId { get; set; }

        public string? ProdDesc { get; set; }

        public int? Cost { get; set; }

        public string? Name { get; set; }

        public string? Img { get; set; }

        public DateOnly? LastDateUpdate { get; set; }

        public short? Oty { get; set; }
        public short? Count { get; set; }

        
        public virtual DtoCategory? Cat { get; set; }

        public virtual ICollection<DtoDetails> Details { get; set; } = new List<DtoDetails>();
    }
}



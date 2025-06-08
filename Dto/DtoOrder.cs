using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class DtoOrder
    {
        public short Ordnum { get; set; }

        public DtoCustomer Cust { get; set; }

        public DateTime OrdDate { get; set; }
        public bool? Ispaid { get; set; }
        public double? Sum { get; set; }
        public List<DtoDetails>? listDetails { get; set; }

        //public virtual DtoCustomer? Cust { get; set; }

        //public virtual ICollection<d> Details { get; set; } = new List<DetailsDto>();
    }
}





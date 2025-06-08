using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class DtoDetails
    {
        public int Id { get; set; }

        public int? Ordnum { get; set; }

        public DtoProducts? Prod { get; set; }

        public int? Qty { get; set; }

        //public virtual DtoOrder? OrdnumNavigation { get; set; }

        //public virtual DtoProducts? Prod { get; set; }
    
}
}

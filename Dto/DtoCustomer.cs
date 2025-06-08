using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class DtoCustomer
    {
        public string CustId { get; set; }

        public string? CustName { get; set; }


        public string? CustCity { get; set; }

        public string? CustPhone { get; set; }

        public string? CustEmail { get; set; }
        public DateTime DateOfBirth { get; set; }
        //public virtual ICollection<DtoOrder> OrderTbls { get; set; } = new List<DtoOrder>();
    }
}



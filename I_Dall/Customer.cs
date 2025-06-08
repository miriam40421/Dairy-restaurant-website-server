using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Dall
{
    public interface  Customer:IDalRepository<DtoCustomer> {
        public Task<DtoCustomer> SelectByIdAsync(string id);
        public Task<bool> AddAsync(DtoCustomer customer);   
    }
}

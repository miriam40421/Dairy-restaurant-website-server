using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Dall
{
    public interface Order :IDalRepository<Dto.DtoOrder>
    {       
        public Task<DtoOrder> SelectByIdAsync(int id);
        public  Task<int> AddAsync(DtoOrder d);

    }
    
    
}

using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Dall
{
  

    public interface IdalDetail: IDalRepository<Dto.DtoDetails>
    {
        //public Task<T> SelectByIdAsync(int id);
        public Task<bool> AddAsync(DtoDetails details);
    }
}

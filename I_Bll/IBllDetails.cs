using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Bll
{
    public interface IBllDetails

    {
        public Task<List<Dto.DtoDetails>> SelectAllAsync();
        //public Task<Dto.DtoDetails> SelectByIdAsync(int id);
        public Task<bool> AddAsync(DtoDetails d);

    }
}

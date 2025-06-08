using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Bll
{
    public interface IBllOrder
    {
        public Task<List<Dto.DtoOrder>> SelectAllAsync();
        public Task<Dto.DtoOrder> SelectByIdAsync(int id);
        public Task<int> AddAsync(DtoOrder d);
        public Task<double?> returnSum(DateTime s,double? c);
    }
}

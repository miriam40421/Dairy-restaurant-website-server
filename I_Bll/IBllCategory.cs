using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Bll
{
    public interface IBllCategory
    {
        public Task<List<Dto.DtoCategory>> SelectAllAsync();

    }
}

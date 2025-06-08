using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class BllCategory:I_Bll.IBllCategory
    {
        I_Dall.IDalRepository<Dto.DtoCategory> c;
        public BllCategory(I_Dall.IDalRepository<Dto.DtoCategory> c)
        {
            this.c = c;
        }
        public async Task<List<Dto.DtoCategory>> SelectAllAsync()
        {
            
            return await c.SelectAllAsync();
        }

        
    }

}

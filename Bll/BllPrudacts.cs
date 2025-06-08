using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class BllPrudacts : I_Bll.IBllPrudacts
    {
        I_Dall.Product prod;
        public BllPrudacts(I_Dall.Product c) 
        {
            this.prod= c;
        }

        public async Task<List<Dto.DtoProducts>> SelectAllAsync()
        {
           
            return await prod.SelectAllAsync();
        }
        public async Task<List<Dto.DtoProducts>> SelectTop()
        {
            return await prod.SelectTop();
        }
        public async Task<Dto.DtoProducts> SelectByIdAsync(int id)
        {
            return await prod.SelectByIdAsync(id);
        }

        public async Task<List<Dto.DtoProducts>> SelecByCategory(int? id, int? cost)
        {
            return await prod.SelecByCategory(id,cost);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Bll
{
    public interface IBllPrudacts
    {
        public Task<List<Dto.DtoProducts>> SelectAllAsync();
        public Task<List<Dto.DtoProducts>> SelectTop();

        public Task<Dto.DtoProducts> SelectByIdAsync(int id);
        public Task<List<Dto.DtoProducts>> SelecByCategory(int? id,int?cost);

    }
}

using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Dall
{
    public interface Product: IDalRepository<Dto.DtoProducts> { 
         public  Task<List<Dto.DtoProducts>> SelecByCategory(int? id,int? cost);
        public  Task<List<Dto.DtoProducts>> SelectTop();
        public Task<DtoProducts> SelectByIdAsync(int id);
        //public Task<List<Dto.DtoProducts>> SelecByCost(int cost);


    }
}

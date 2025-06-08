using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Models;
using I_Dall;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dal;
using System.Collections;
namespace Dal.DalClasses
{
    public class DalPrudact : I_Dall.Product
    {
        BigBiteContext db;
        public DalPrudact(BigBiteContext db)
        {
            this.db = db;
        }
        public async Task<List<Dto.DtoProducts>> SelectAllAsync()
        {
            var q = await db.ProductsTbls.Include(c => c.Cat).ToListAsync();
            return converts.ConvertPrudact.ToListPrudacts(q);
        }


        public async Task<List<Dto.DtoProducts>> SelectTop()
        {

            var q = await db.ProductsTbls.Include(c => c.Cat).OrderByDescending(i => i.LastDateUpdate).Take(10).ToListAsync();
            return converts.ConvertPrudact.ToListPrudacts(q);
        }
        public async Task<Dto.DtoProducts> SelectByIdAsync(int id)
        {
            var q = await db.ProductsTbls.FirstAsync(x => x.ProdId == id);
            return converts.ConvertPrudact.ConvertToDto(q);
        }
        public async Task<List<Dto.DtoProducts>> SelecByCategory(int? id, int? cost)
        {
            if (id != null && cost != null)
            {
                var q = await db.ProductsTbls.Include(c => c.Cat).Where(x => x.CatId == id && x.Cost <= cost).ToListAsync();
                return converts.ConvertPrudact.ToListPrudacts(q);

            }
            else if (id == null && cost != null)
            {
                var q = await db.ProductsTbls.Include(c => c.Cat).Where(x => x.Cost <= cost).ToListAsync();
                return converts.ConvertPrudact.ToListPrudacts(q);

            }
            else
            {
                var q = await db.ProductsTbls.Include(c => c.Cat).Where(x => x.CatId == id).ToListAsync();
                return converts.ConvertPrudact.ToListPrudacts(q);

            }
        }


        //public async Task<List<Dto.DtoProducts>> SelecByCost(int cost)
        //{
        //    var q = await db.ProductsTbls.Where(x => x.Cost >= cost).ToListAsync();
        //    return converts.ConvertPrudact.ToListPrudacts(q);
        //}


    }


}




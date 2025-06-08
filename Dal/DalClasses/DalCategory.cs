using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dto;
using I_Dall;

namespace Dal.DalClasses
{
    public class DalCategory : I_Dall.Category
    {
        BigBiteContext db;
        public DalCategory(BigBiteContext db)
        {
            this.db = db;
        }

        public async Task<List<Dto.DtoCategory>> SelectAllAsync()
        {
            var q = await db.CategoryTbls.ToListAsync();
            return converts.ConvertCategory.ToListCategory(q);
        }

        public async Task<int> AddAsync(Dto.DtoCategory c)
        {
            db.CategoryTbls.Add(converts.ConvertCategory.convertTomic(c));
            int x = await db.SaveChangesAsync();
            return x;
        }

    }
}


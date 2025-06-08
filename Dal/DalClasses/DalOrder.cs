using Dal.Models;
using Dto;
using I_Dall;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Dal;
namespace Dal.DalClasses
{
    public class DalOrder : Order
    {
        BigBiteContext db;
        public DalOrder(BigBiteContext db)
        {
            this.db = db;
        }
        public async Task<List<Dto.DtoOrder>> SelectAllAsync()
        {
            var q = await db.OrderTbls.Include(o => o.DetailsTbls).ToListAsync();
            return converts.ConvertOrder.ToListOrders(q);
        }
        public async Task<Dto.DtoOrder> SelectByIdAsync(int id)
        {
            var q = await db.OrderTbls.FirstAsync(x => x.Ordnum == id);
            return converts.ConvertOrder.ConvertToDto(q);
        }


        public async Task<int> AddAsync(DtoOrder d)
        {


            var orderEntity = converts.ConvertOrder.convertTomic(d);
            db.OrderTbls.Add(orderEntity);
            await db.SaveChangesAsync();
            return orderEntity.Ordnum;
        }

    }
}

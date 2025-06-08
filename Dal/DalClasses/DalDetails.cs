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
    public class DalDetails : IdalDetail
    {
        BigBiteContext db;
        public DalDetails(BigBiteContext db)
        {
            this.db = db;
        }
        public async Task<List<Dto.DtoDetails>> SelectAllAsync()
        {
            var q = await db.DetailsTbls.ToListAsync();
            return converts.ConvertDetails.ToListDetails(q);
        }
        public async Task<bool> AddAsync(DtoDetails d)
        {
            Dto.DtoDetails newdetail = new Dto.DtoDetails();
            //newdetail.Qty = d.Qty;
            //newdetail.Ordnum = d.Ordnum;
            //newdetail.Id = d.Id;
            //newdetail.Prod.ProdId = d.Prod.ProdId;
            //var detailEntity = converts.ConvertDetails.convertTomic(d);
            db.DetailsTbls.Add(converts.ConvertDetails.convertTomic(d));
            await db.SaveChangesAsync();
            return true;
        }
    }
}

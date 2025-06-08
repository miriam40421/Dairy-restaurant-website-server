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
using Dto;
namespace Dal.DalClasses
{
    public class DalCustomer:I_Dall.Customer
    {

        BigBiteContext db;
        public DalCustomer(BigBiteContext db)
        {
            this.db = db;
        }

        public async Task<List<Dto.DtoCustomer>> SelectAllAsync()
            {
                var q = await db.CustumerTbls.ToListAsync();
                return converts.ConvertCostumer.ToListCustomer(q);
            }
        public async Task<Dto.DtoCustomer> SelectByIdAsync(string id)
        {
            var q = await db.CustumerTbls.FirstAsync(x => x.CustId == id);
            return converts.ConvertCostumer.ConvertToDto(q);
            
        }
        public async Task<bool> AddAsync(Dto.DtoCustomer c)
        {
            db.CustumerTbls.Add(converts.ConvertCostumer.convertTomic(c));
             await db.SaveChangesAsync();
            return true;
        }
    }


    }

using Dto;
using I_Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class BllDetails1:I_Bll.IBllDetails
    {

        I_Dall.IdalDetail c;
        public BllDetails1(I_Dall.IdalDetail c)
        {
            this.c = c;
        }
        public async Task<List<Dto.DtoDetails>> SelectAllAsync()
        {            return await c.SelectAllAsync();
        }
        public async Task<bool> AddAsync(DtoDetails d)
        {
            return await c.AddAsync(d);
        }


    }
}

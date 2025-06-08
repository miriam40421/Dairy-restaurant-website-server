using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Dall
{
            public interface Category : IDalRepository<DtoCategory>
        {
            //public Task<DtoCategory> /*SelectByIdAsync*/(int id);
        }
}

using Dto;
using I_Dall;

namespace Bll
{
    public class Bllcotumer:I_Bll.ICustomerBll
    {
        I_Dall.Customer c;
        public Bllcotumer(I_Dall.Customer c)
        {
            this.c = c;
        }

        public async Task<List<Dto.DtoCustomer>> SelectAllAsync()
        {
            return await c.SelectAllAsync();
        }
        public async Task<Dto.DtoCustomer> SelectByIdAsync(string id)
        {
            return await c.SelectByIdAsync( id);
        }

        public async Task<bool> AddAsync(DtoCustomer d)
        {
            return await c.AddAsync(d);
        }

    }
}
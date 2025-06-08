using Dto;

namespace I_Bll
{
    
        public interface ICustomerBll
        {
            public Task<List<Dto.DtoCustomer>> SelectAllAsync();
           public Task<Dto.DtoCustomer> SelectByIdAsync(string id);
           public Task<bool> AddAsync(DtoCustomer d);


    }
}

using Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        I_Bll.ICustomerBll cust;
        public CustomerController(I_Bll.ICustomerBll c)
        {
            this.cust = c;

        }
        [HttpGet]
        public async Task<List<Dto.DtoCustomer>> GetAsync()
        {
            return await cust.SelectAllAsync();
        }

        [HttpGet("{CustId}")]
        public async Task<Dto.DtoCustomer> GetByCustIdAsync(string CustId)
        {
            return await cust.SelectByIdAsync(CustId);
        }

        [HttpPost]
        public async Task<bool> AddAsync(Dto.DtoCustomer c)
        {
            //Bll_Services.CoursesBll c = new Bll_Services.CoursesBll();
            return await cust.AddAsync(c);
 
        }


    }
}

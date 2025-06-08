using Dal.Models;
using Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        I_Bll.IBllOrder Order;
        public OrderController(I_Bll.IBllOrder o)
        {
            this.Order= o;

        }
        [HttpGet]
        public async Task<List<Dto.DtoOrder>> GetAsync()
        {
            return await Order.SelectAllAsync();
        }

        [HttpGet("{OrdId}")]
        public async Task<Dto.DtoOrder> GetByCustIdAsync(int OrdId)
        {
            return await Order.SelectByIdAsync(OrdId);
        }

        [HttpPost]
        public async Task<int> AddAsync(DtoOrder d)
        {
            return await Order.AddAsync(d);
        }
        [HttpPost("/a")]
        public async Task<double?> returnSum(DateTime s,double? c)
        {
            return await Order.returnSum(s,c);
        }

    }

}

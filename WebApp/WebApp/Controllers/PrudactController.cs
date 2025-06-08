
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrudactController : ControllerBase
    {
        I_Bll.IBllPrudacts p;

        public PrudactController(I_Bll.IBllPrudacts c)
        {
            this.p = c;

        }
        [HttpGet]
        public async Task<List<Dto.DtoProducts>> GetAsync()
        {
            //Bll_Services.CoursesBll c = new Bll_Services.CoursesBll();
            return await p.SelectAllAsync();
        }

        [HttpGet("top")]
        public async Task<List<Dto.DtoProducts>> GetTopAsync()
        {
            return await p.SelectTop();
        }
        
        [HttpGet("{ProdId}")]
        public async Task<Dto.DtoProducts> GetByProdIdAsync(int ProdId)
        {
            return await p.SelectByIdAsync(ProdId);
        }

        [HttpGet("ByName")]
        public async Task<List<Dto.DtoProducts>> GetByCatIdAsync(int? CatId, int? cost)
        {
            return await p.SelecByCategory(CatId, cost);
        }
    }
}

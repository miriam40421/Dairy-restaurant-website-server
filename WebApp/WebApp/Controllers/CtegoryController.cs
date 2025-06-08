using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CtegoryController : ControllerBase
    {
        I_Bll.IBllCategory Category;
        public CtegoryController(I_Bll.IBllCategory c)
        {
            this.Category = c;

        }
        [HttpGet]
        public async Task<List<Dto.DtoCategory>> GetAsync()
        {
            return await Category.SelectAllAsync();
        }

        //[HttpGet("{CatId}")]
        //public async Task<Dto.DtoCategory> GetByCatIdAsync(int CatId)
        //{
        //    //Bll_Services.CoursesBll c = new Bll_Services.CoursesBll();
        //    return await Category.SelectByIdAsync(CatId);
        //}
    }
}
   


using Dto;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetailController : ControllerBase
    {
        I_Bll.IBllDetails bllDetails;
        public DetailController(I_Bll.IBllDetails D)
        {
            this.bllDetails = D;
        }
        [HttpGet]
        public async Task<List<Dto.DtoDetails>> GetAsync()
        {
            return await bllDetails.SelectAllAsync();
        }

        //[HttpGet("{Id}")]
        //public async Task<Dto.DtoDetails> GetByDetIdAsync(int Id)
        //{
        //    //Bll_Services.CoursesBll c = new Bll_Services.CoursesBll();
        //    return await bllDetails.SelectByIdAsync(Id);
        //}

        [HttpPost]
        public async Task<bool> AddAsync(DtoDetails d)
        {
            //Bll_Services.CoursesBll c = new Bll_Services.CoursesBll();
            return await bllDetails.AddAsync(d);
        }

    }
}




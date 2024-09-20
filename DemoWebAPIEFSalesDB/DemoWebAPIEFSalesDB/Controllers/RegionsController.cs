using DemoWebAPIEFSalesDB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoWebAPIEFSalesDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly SalesDBContext _salesDBContext;
        //static List<string> Regions = new List<string>();
        public RegionsController(SalesDBContext salesDBContext)
        {
            _salesDBContext = salesDBContext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Region>>> GetRegions()
        {
            return await _salesDBContext.Regions.ToListAsync();
        }






    }
}

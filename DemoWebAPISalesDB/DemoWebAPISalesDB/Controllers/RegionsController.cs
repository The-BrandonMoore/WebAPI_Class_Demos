using Microsoft.AspNetCore.Mvc;

namespace DemoWebAPISalesDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        static List<string> regions = new() { "north", "south", "east", "west"};
        [HttpGet]
        public List<string> GetAllRegions()
        {
            if (regions.Count == 0)
                return new List<string> { "No regions in list yet" };
            else
                return regions;
        }
        [HttpGet("{idx}")]
        public string GetRegionByIdx(int idx)
        {
            if (idx < 0 || idx >= regions.Count)
                return "No region at that index position. Try again.";
            else 
                return regions[idx];
        }
        [HttpPost]
        public string AddRegion(string region)
        {
            regions.Add(region);
            return "Region Added";
        }
        [HttpDelete("{idx}")]
        public string RemoveRegion(int idx)
        {
            regions.RemoveAt(idx);
            return "Region Removed";
        }
        [HttpPut]
        public string UpdateRegion(int idx, string updatedRegion)
        {

            if (idx < 0 || idx >= regions.Count)
                return "No region at that index position. Try again.";
            else
            {
                regions[idx] = updatedRegion;
                return "Region Updated";
            }
        }







        }
}

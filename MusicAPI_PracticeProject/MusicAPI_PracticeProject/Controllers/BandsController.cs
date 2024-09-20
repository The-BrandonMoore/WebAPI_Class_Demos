using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

namespace MusicAPI_PracticeProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BandsController : ControllerBase
    {
        static List<string> Bands = new List<string> { "The Offspring", "Relient K", "Foo Fighters", "Falling In Reverse", "Papa Roach", "Blink-182" };


        [HttpGet]
        public List<string> GetAllBands()
        {
            return Bands;
        }

        [HttpGet("{idx}")]
        public string GetBandByIdx(int idx) {
            if (idx < 0 || idx >= Bands.Count)
            {
                return "no band found";
            }
            else return Bands[idx];
        }
        [HttpDelete("{idx}")]
        public string DeleteBandByIdx(int idx)
        {
            Bands.RemoveAt(idx);
            return "Band deleted";
        }
        [HttpPost]
        public string AddBand(string band)
        {
            Bands.Add(band);
            return "Band Added";
        }
        [HttpPut]
        public string UpdateBand(int idx, string updatedBand)
        {
            if (idx < 0 || idx >= Bands.Count)
            {
                return "no band found";
            }

            else
            {
                Bands[idx] = updatedBand;
                return "Band Updated";
            }
        }


        }
}

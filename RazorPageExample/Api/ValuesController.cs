using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RazorPageExample.Api
{
    [Route("api/values")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("name")]
        public string GetName()
        {
            return "Inigo";
        }

        [HttpGet("List")]
        public IEnumerable<string> List()
        {
            return new string[] { "Grant", "Jonikka", "Mark" };
        }

        [HttpGet("Weather")]
        public Weather Weather(int? number)
        {
            return new Weather
            {
                Name = "Test",
                Description = "Cloudy",
                Number = number
            };
        }



    }
    public class Weather
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Number { get; set; }
    }
}

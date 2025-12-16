using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BarbieLab.Controllers
{
    public class CollapseItem
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class CollapseController : ControllerBase
    {
      
        private static List<CollapseItem> _sharedData = new List<CollapseItem>();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_sharedData);
        }

        [HttpPost]
        public IActionResult Post([FromBody] List<CollapseItem> data)
        {
            _sharedData = data;
            return Ok(new { message = "Data saved successfully to Barbie Server!" });
        }
    }
}
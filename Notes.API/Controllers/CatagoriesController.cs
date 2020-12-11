using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Notes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatagoriesController : ControllerBase
    {
        // GET: api/catagories
        //      api/catagories?search=""
        [HttpGet]
        public IEnumerable<string> Get([FromQuery] string search)
        {
            return new string[] { "value1", "value2" };
        }


        // POST api/catagories
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/catagories/catagory1
        [HttpPut("{name}")]
        public void Put(string name, [FromBody] string value)
        {
        }

        // DELETE api/catagories/catagory1
        [HttpDelete("{name}")]
        public void Delete(string name)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Notes.API.Controllers
{
    [Route("api/Catagoires/{CatagoryName=Uncatagorized}/Notes")]
    [ApiController]
    public class CatagoryController : ControllerBase
    {


        // GET api/Catagoires/5
        [HttpGet]
        public string Get(string CatagoryName)
        {
            return "value";
        }

        [HttpGet]
        public IEnumerable<string> GetNotes([FromQuery] string search)
        {
            return new string[] { "value1", "value2" };
        }

        // POST api/Catagories/CatagoryName
        [HttpPost]
        public void Post(string CatagoryName, [FromBody] string value)
        {
        }

        // PUT api/Catagories/CatagoryName
        [HttpPut]
        public void Put(string CatagoryName, [FromBody] string value)
        {
        }

        // DELETE api/Catagories/CatagoryName
        [HttpDelete]
        public void Delete(string CatagoryName)
        {
        }
    }
}

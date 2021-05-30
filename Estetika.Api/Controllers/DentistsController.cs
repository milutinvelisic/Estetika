using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Estetika.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DentistsController : ControllerBase
    {
        // GET: api/<DentistsController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        // GET api/<DentistsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DentistsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DentistsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DentistsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

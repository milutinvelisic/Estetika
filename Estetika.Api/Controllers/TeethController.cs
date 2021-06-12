using Estetika.Application;
using Estetika.Application.Commands;
using Estetika.Application.DataTransfer;
using Estetika.DataAccess;
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
    public class TeethController : ControllerBase
    {
        private readonly EstetikaContext context;
        private readonly IApplicationActor actor;
        private readonly UseCaseExecutor executor;

        public TeethController(EstetikaContext context, IApplicationActor actor, UseCaseExecutor executor)
        {
            this.context = context;
            this.actor = actor;
            this.executor = executor;
        }

        // GET: api/<TeethController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TeethController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TeethController>
        [HttpPost]
        public IActionResult Post([FromBody] TeethDto dto, [FromServices] ICreateTeethCommand command)
        {
            executor.ExecuteCommand(command, dto);
            return NoContent();
        }

        // PUT api/<TeethController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] TeethDto dto, [FromServices] IUpdateTeethCommand command)
        {
            dto.Id = id;
            executor.ExecuteCommand(command, dto);
            return NoContent();
        }

        // DELETE api/<TeethController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromServices] IDeleteTeethCommand command)
        {
            executor.ExecuteCommand(command, id);
            return NoContent();
        }
    }
}

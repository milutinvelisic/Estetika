using Estetika.Application;
using Estetika.Application.Commands;
using Estetika.Application.DataTransfer;
using Estetika.Application.Queries;
using Estetika.Application.Searches;
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
    public class EKartonController : ControllerBase
    {
        private readonly EstetikaContext context;
        private readonly IApplicationActor actor;
        private readonly UseCaseExecutor executor;

        public EKartonController(EstetikaContext context, IApplicationActor actor, UseCaseExecutor executor)
        {
            this.context = context;
            this.actor = actor;
            this.executor = executor;
        }

        // GET: api/<EKartonController>
        [HttpGet]
        public IActionResult Get([FromQuery] EKartonSearch search, [FromServices] IGetEKartonQuery query)
        {
            return Ok(executor.ExecuteQuery(query, search));
        }

        // GET api/<EKartonController>/5
        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id, [FromServices] IGetOneEKartonQuery query)
        {
            return Ok(executor.ExecuteQuery(query, id));
        }

        // POST api/<EKartonController>
        [HttpPost]
        public IActionResult Post([FromBody] EkartonDto dto, [FromServices] ICreateEKartonCommand command)
        {
            executor.ExecuteCommand(command, dto);
            return NoContent();
        }

        // PUT api/<EKartonController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] EkartonDto dto, [FromServices] IUpdateEKartonCommand command)
        {
            dto.Id = id;
            executor.ExecuteCommand(command, dto);
            return NoContent();
        }

        // DELETE api/<EKartonController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromServices] IDeleteEKartonCommand command)
        {
            executor.ExecuteCommand(command, id);
            return NoContent();
        }
    }
}

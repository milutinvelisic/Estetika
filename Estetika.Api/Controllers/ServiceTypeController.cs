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
    public class ServiceTypeController : ControllerBase
    {
        private readonly EstetikaContext context;
        private readonly IApplicationActor actor;
        private readonly UseCaseExecutor executor;

        public ServiceTypeController(EstetikaContext context, IApplicationActor actor, UseCaseExecutor executor)
        {
            this.context = context;
            this.actor = actor;
            this.executor = executor;
        }

        // GET: api/<ServiceTypeController>
        [HttpGet]
        public IActionResult Get([FromQuery] ServiceTypeSearch search, [FromServices] IGetServiceTypeQuery query)
        {
            return Ok(executor.ExecuteQuery(query, search));
        }

        // GET api/<ServiceTypeController>/5
        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id, [FromServices] IGetOneServiceTypeQuery query)
        {
            return Ok(executor.ExecuteQuery(query, id));
        }

        // POST api/<ServiceTypeController>
        [HttpPost]
        public IActionResult Post([FromBody] ServiceTypeDto dto, [FromServices] ICreateServiceTypeCommand command)
        {
            executor.ExecuteCommand(command, dto);
            return NoContent();
        }

        // PUT api/<ServiceTypeController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ServiceTypeDto dto, [FromServices] IUpdateServiceTypeCommand command)
        {
            dto.Id = id;
            executor.ExecuteCommand(command, dto);
            return NoContent();
        }

        // DELETE api/<ServiceTypeController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromServices] IDeleteServiceTypeCommand command)
        {
            executor.ExecuteCommand(command, id);
            return NoContent();
        }
    }
}

using Estetika.Application;
using Estetika.Application.Commands;
using Estetika.Application.DataTransfer;
using Estetika.Application.Exceptions;
using Estetika.Application.Queries;
using Estetika.Application.Searches;
using Estetika.DataAccess;
using Estetika.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Estetika.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {

        private readonly EstetikaContext _estetikaContext;
        private readonly IApplicationActor actor;
        private readonly UseCaseExecutor executor;

        public RolesController(EstetikaContext estetikaContext, IApplicationActor actor, UseCaseExecutor executor)
        {
            _estetikaContext = estetikaContext;
            this.actor = actor;
            this.executor = executor;
        }


        // GET: api/<RolesController>
        [HttpGet]
        public IActionResult Get([FromQuery] RoleSearch search, [FromServices] IGetRoleQuery query)
        {
            return Ok(executor.ExecuteQuery(query, search));
        }

        // GET api/<RolesController>/5
        [HttpGet("{id}")]
        public IActionResult Get([FromRoute]int id, [FromServices] IGetOneRoleQuery query)
        {
            return Ok(executor.ExecuteQuery(query, id));
        }

        // POST api/<RolesController>
        [HttpPost]
        public IActionResult Post([FromBody] RoleDto dto, [FromServices] ICreateRoleCommand command)
        {
            executor.ExecuteCommand(command, dto);
            return NoContent();
        }

        // PUT api/<RolesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] RoleDto dto, [FromServices] IUpdateRoleCommand command)
        {
            dto.Id = id;
            executor.ExecuteCommand(command, dto);
            return NoContent();
        }

        // DELETE api/<RolesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromServices] IDeleteRoleCommand command)
        {
            executor.ExecuteCommand(command, id);
            return NoContent();

        }
    }

}

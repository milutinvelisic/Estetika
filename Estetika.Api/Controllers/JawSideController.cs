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
    public class JawSideController : ControllerBase
    {
        private readonly EstetikaContext context;
        private readonly IApplicationActor actor;
        private readonly UseCaseExecutor executor;

        public JawSideController(EstetikaContext context, IApplicationActor actor, UseCaseExecutor executor)
        {
            this.context = context;
            this.actor = actor;
            this.executor = executor;
        }

        // POST api/<JawSideController>
        [HttpPost]
        public IActionResult Post([FromBody] JawSideDto dto, [FromServices] ICreateJawSideCommand command)
        {
            executor.ExecuteCommand(command, dto);
            return NoContent();
        }

        // PUT api/<JawSideController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] JawSideDto dto, [FromServices] IUpdateJawSideCommand command)
        {
            dto.Id = id;
            executor.ExecuteCommand(command, dto);
            return NoContent();
        }

        // DELETE api/<JawSideController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromServices] IDeleteJawSideCommand command)
        {
            executor.ExecuteCommand(command, id);
            return NoContent();
        }
    }
}

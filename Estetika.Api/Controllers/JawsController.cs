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
    public class JawsController : ControllerBase
    {
        private readonly EstetikaContext context;
        private readonly IApplicationActor actor;
        private readonly UseCaseExecutor executor;

        public JawsController(EstetikaContext context, IApplicationActor actor, UseCaseExecutor executor)
        {
            this.context = context;
            this.actor = actor;
            this.executor = executor;
        }

        // POST api/<JawsController>
        [HttpPost]
        public IActionResult Post([FromBody] JawDto dto, [FromServices] ICreateJawCommand command)
        {
            executor.ExecuteCommand(command, dto);
            return NoContent();
        }

        // PUT api/<JawsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] JawDto dto, [FromServices] IUpdateJawCommand command)
        {
            dto.Id = id;
            executor.ExecuteCommand(command, dto);
            return NoContent();
        }

        // DELETE api/<JawsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromServices] IDeleteJawCommand command)
        {
            executor.ExecuteCommand(command, id);
            return NoContent();
        }
    }
}

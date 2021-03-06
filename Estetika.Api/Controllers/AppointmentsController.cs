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
    public class AppointmentsController : ControllerBase
    {
        private readonly EstetikaContext context;
        private readonly IApplicationActor actor;
        private readonly UseCaseExecutor executor;

        public AppointmentsController(EstetikaContext context, IApplicationActor actor, UseCaseExecutor executor)
        {
            this.context = context;
            this.actor = actor;
            this.executor = executor;
        }

        // GET: api/<AppointmentsController>
        [HttpGet]
        public IActionResult Get([FromQuery] AppointmentSearch search, [FromServices] IGetAppointmentQuery query)
        {
            return Ok(executor.ExecuteQuery(query, search));
        }

        // POST api/<AppointmentsController>
        [HttpPost]
        public IActionResult Post([FromBody] AppointmentDto dto, [FromServices] ICreateAppointmentCommand command)
        {
            executor.ExecuteCommand(command, dto);
            return NoContent();
        }
    }
}

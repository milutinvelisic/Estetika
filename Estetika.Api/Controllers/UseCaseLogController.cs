using Estetika.Application;
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
    public class UseCaseLogController : ControllerBase
    {
        private readonly EstetikaContext context;
        private readonly IApplicationActor actor;
        private readonly UseCaseExecutor executor;

        public UseCaseLogController(EstetikaContext context, IApplicationActor actor, UseCaseExecutor executor)
        {
            this.context = context;
            this.actor = actor;
            this.executor = executor;
        }

        // GET: api/<UseCaseLogController>
        [HttpGet]
        public IActionResult Get([FromQuery] UseCaseSearchSearch search, [FromServices] IGetUseCaseLogQuery query)
        {
            return Ok(executor.ExecuteQuery(query, search));
        }
    }
}

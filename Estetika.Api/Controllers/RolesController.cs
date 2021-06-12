using Estetika.Application;
using Estetika.Application.Commands;
using Estetika.Application.DataTransfer;
using Estetika.Application.Exceptions;
using Estetika.DataAccess;
using Estetika.Domain;
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
        public IActionResult Get()
        {
            return Ok(actor);
            //var roles = _estetikaContext.Roles.ToList();

            //return Ok(roles);
        }

        // GET api/<RolesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RolesController>
        [HttpPost]
        public void Post([FromBody] RoleDto dto, [FromServices] ICreateRoleCommand command)
        {

            executor.ExecuteCommand(command, dto);

            //var role = new Role
            //{
            //    RoleName = dto.RoleName
            //};

            //_estetikaContext.Roles.Add(role);

            //_estetikaContext.SaveChanges();
        }

        // PUT api/<RolesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] RolesDto dto)
        {
            var role = _estetikaContext.Roles.Find(id);

            if(role == null)
            {
                return NotFound();
            }

            role.RoleName = dto.RoleName;

            try
            {
                _estetikaContext.SaveChanges();
                return NoContent();
            }
            catch(Exception ex)
            {
                return StatusCode(500);
            }
        }

        // DELETE api/<RolesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromServices] IDeleteRoleCommand command)
        {
            executor.ExecuteCommand(command, id);
            return NoContent();

            //var role = _estetikaContext.Roles.Find(id);

            //if (role == null)
            //{
            //    return NotFound();
            //}

            //try
            //{
            //    role.IsDeleted = true;

            //    _estetikaContext.SaveChanges();

            //    return NoContent();
            //}
            //catch (Exception ex)
            //{
            //    return StatusCode(500);
            //}
        }
    }

    public class RolesDto
    {
        public string RoleName { get; set; }
    }
}

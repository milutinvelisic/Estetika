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
    public class TestController : ControllerBase
    {
        private readonly EstetikaContext _estetikaContext;

        public TestController(EstetikaContext estetikaContext)
        {
            _estetikaContext = estetikaContext;
        }

        // GET: api/<TestController>
        [HttpGet]
        public void Get()
        {
            var userList = new List<User>
            {
                new User
                {
                    FirstName = "pera",
                    LastName = "peric",
                    Email = "pera@gmail.com",
                    Password = "pera123",
                    Phone = "123456789",
                    RoleId = 1
                }
            };

            var userUseCases = new List<UserUseCases>
            {
                new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 1
                },
                 new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 2
                },
                  new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 3
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 4
                },
                   new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 5
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 6
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 7
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 8
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 9
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 10
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 11
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 12
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 13
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 14
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 15
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 16
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 17
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 18
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 19
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 20
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 21
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 22
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 23
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 24
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 25
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 26
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 27
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 28
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 29
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 30
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 31
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 32
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 33
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 34
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 35
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 36
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 37
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 38
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 39
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 40
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 41
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 42
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 43
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 44
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 45
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 46
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 47
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 48
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 49
                }, new UserUseCases
                {
                    UserId = userList.ElementAt(0).Id,
                    UseCaseId = 50
                }
            };

            //_estetikaContext.Users.AddRange(userList);
            _estetikaContext.UserUseCases.AddRange(userUseCases);
            _estetikaContext.SaveChanges();
        }
    }
}

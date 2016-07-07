using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiArchitectureDemo.Common.DTOs;

namespace WebApiArchitectureDemo.Api.Controllers
{
    [RoutePrefix("users")]
    public class UsersController : ApiController
    {
        [HttpGet]
        [Route("all")]
        public IHttpActionResult GetAll()
        {
            var users = new List<User>();

            users.Add(new User()
            {
                FirstName = "Marco",
                LastName = "Polo",
                DateOfBirth = new DateTime(1254, 1, 14),
                Username = "greatadventurer"
            });

            users.Add(new User()
            {
                FirstName = "Kublai",
                LastName = "Khan",
                DateOfBirth = new DateTime(1215, 9, 23),
                Username = "khanofkhans"
            });

            users.Add(new User()
            {
                FirstName = "Kokachin",
                LastName = "",
                DateOfBirth = new DateTime(1255, 8, 17),
                Username = "blueprincess"
            });

            return Ok(users);
        }
    }
}

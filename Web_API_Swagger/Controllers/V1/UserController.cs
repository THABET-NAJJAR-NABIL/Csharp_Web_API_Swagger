using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_API_Swagger.Model;
using Web_API_Swagger.Contracts;

namespace Web_API_Swagger.Controllers
{
    public class UserController : Controller
    {

          [HttpPost(ApiRoutes.User.saveUser)]
        public IActionResult CreatePost([FromBody] Perosn person)
        {
            Console.WriteLine(person);
            return Ok(person);
        }
        
    }
}
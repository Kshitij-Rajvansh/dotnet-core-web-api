using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotnetWebApi.Models;

namespace DotnetWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static Character Knight = new Character();

        public IActionResult Get()
        {
            return Ok(Knight);
        }
    }
}
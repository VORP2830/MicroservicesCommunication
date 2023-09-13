using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Products_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatusController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() 
        {
            var response = new 
            {
                service = "Products-API",
                status = "up",
                httpStatus = 200
            };
            return Ok(response);
        }
    }
}
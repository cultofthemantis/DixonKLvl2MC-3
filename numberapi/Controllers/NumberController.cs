using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace numberapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NumberController : ControllerBase
    {
        [HttpGet]
        public string Addition(int num1, int num2)
        {   
            int sum = num1 + num2;
            return $"The sum of {num1} and {num2} is {sum}";
        }
        
            
        
    }
}
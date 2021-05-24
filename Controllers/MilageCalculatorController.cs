using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AlaskaAirMilesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MilageCalculatorController : ControllerBase
    {
        [HttpGet("{city}")]
        public ActionResult<MilageCalculator> Get(string city)
        {
            
        }
    }
}

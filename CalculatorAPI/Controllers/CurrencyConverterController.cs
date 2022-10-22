using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyConverterAPI.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyConverterController : ControllerBase
    {
        // GET: api/CurrencyConverter
        [HttpGet("convert/{a}/{b}")]
        public string add(float a, float b)
        {
            CurrencyConverterAPI.Model.CurrencyConverter cal = new Model.CurrencyConverter(a, b);
            cal.mul();
            return cal.result.ToString();
        }

    }
}

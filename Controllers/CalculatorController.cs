using System.Collections.Specialized;
using Microsoft.AspNetCore.Http; 
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("sum")]
        public IActionResult GetSum([FromQuery] int a, [FromQuery] int b)
        {
            var result = a + b;
            return Ok(new { a, b, result });
        }

        [HttpGet("rest")]
        public IActionResult GetRest([FromQuery] int c, [FromQuery] int d)
        {
            var result2 = c - d;
            return Ok(new { c, d, result2 });
        }

        [HttpGet("mult")]
        public IActionResult GetMult([FromQuery] int e, [FromQuery] int f)
        {
            var result3 = e * f;
            return Ok(new { e, f, result3 });
        }

        
        [HttpGet("div")]
        public IActionResult GetDiv([FromQuery] int a, [FromQuery] int b)
        {
            if (b == 0) return BadRequest(new { message = "La división no es disponible ya que incluye un cero " });
            double result = (double)a / b;
            return Ok(new { a, b, result });
        }


    }
}

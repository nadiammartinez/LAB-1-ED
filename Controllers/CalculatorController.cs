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
            return Ok(new { a, b, result});
        }
        
        [HttpGet("rest")]
        public IActionResult GetSum([FromQuery] int c, [FromQuery] int d)
        {
            var result2 = c - d;
            return Ok(new { c, d, result2});
        }
    }
}

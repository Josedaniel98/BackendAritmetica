using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ArithmeticController : ControllerBase
{
    [HttpGet("sum")]
    public IActionResult Sum([FromQuery] int num1, [FromQuery] int num2)
    {
        return Ok(num1 + num2);
    }

    [HttpGet("subtract")]
    public IActionResult Subtract([FromQuery] int num1, [FromQuery] int num2)
    {
        return Ok(num1 - num2);
    }

    [HttpGet("multiply")]
    public IActionResult Multiply([FromQuery] int num1, [FromQuery] int num2)
    {
        return Ok(num1 * num2);
    }

    [HttpGet("divide")]
    public IActionResult Divide([FromQuery] int num1, [FromQuery] int num2)
    {
        if (num2 == 0)
        {
            return BadRequest("La división por cero no está permitida.");
        }

        return Ok((double)num1 / num2);
    }
}

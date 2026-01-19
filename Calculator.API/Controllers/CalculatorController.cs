using Microsoft.AspNetCore.Mvc;
using Calculator.API.Services;

namespace Calculator.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly ICalculatorService _calculatorService;

    public CalculatorController(ICalculatorService calculatorService)
    {
        _calculatorService = calculatorService;
    }

    [HttpPost("add")]
    public IActionResult Add([FromBody] CalculationRequest request)
    {
        try
        {
            var result = _calculatorService.Add(request.A, request.B);
            return Ok(new { result });
        }
        catch (Exception ex)
        {
            return BadRequest(new { error = ex.Message });
        }
    }

    [HttpPost("subtract")]
    public IActionResult Subtract([FromBody] CalculationRequest request)
    {
        try
        {
            var result = _calculatorService.Subtract(request.A, request.B);
            return Ok(new { result });
        }
        catch (Exception ex)
        {
            return BadRequest(new { error = ex.Message });
        }
    }

    [HttpPost("multiply")]
    public IActionResult Multiply([FromBody] CalculationRequest request)
    {
        try
        {
            var result = _calculatorService.Multiply(request.A, request.B);
            return Ok(new { result });
        }
        catch (Exception ex)
        {
            return BadRequest(new { error = ex.Message });
        }
    }

    [HttpPost("divide")]
    public IActionResult Divide([FromBody] CalculationRequest request)
    {
        try
        {
            var result = _calculatorService.Divide(request.A, request.B);
            return Ok(new { result });
        }
        catch (DivideByZeroException ex)
        {
            return BadRequest(new { error = ex.Message });
        }
        catch (Exception ex)
        {
            return BadRequest(new { error = ex.Message });
        }
    }
}

public class CalculationRequest
{
    public double A { get; set; }
    public double B { get; set; }
}

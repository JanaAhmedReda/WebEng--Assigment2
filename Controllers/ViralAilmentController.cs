using Microsoft.AspNetCore.Mvc;
using Assignment1.Models;
using Assignment1.Interfaces;

namespace Assignment1.Controllers;

[Route("ailments")]
[ApiController]
public class ViralAilmentController : ControllerBase
{
    private readonly IViralAilmentService _service;

    public ViralAilmentController(IViralAilmentService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetInfections()
    {
        var infections = _service.GetInfections();
        return Ok(infections);
    }

    [HttpPost("tax/{term}")]
    public IActionResult TaxAilment(string term)
    {
        _service.ApplyFanumTax(term);
        return Ok(new { message = $"Fanum tax collected from {term}." });
    }

    [HttpDelete("{term}")]
    public IActionResult RemoveCringe(string term)
    {
        _service.DeleteCringe(term);
        return NoContent();
    }
}
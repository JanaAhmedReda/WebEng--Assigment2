using Microsoft.AspNetCore.Mvc;
using Assignment1.Interfaces;

namespace Assignment1.Controllers;
[Route("rotters")]
[ApiController]

public class BrainRotterController : ControllerBase
{
    private readonly IBrainRotterService _service;

    
    public BrainRotterController(IBrainRotterService brainRotterService)
    {
        _service = brainRotterService; 
    }

   [HttpGet]
    public IActionResult GetLobby()
    {
        var lobby = _service.GetLobby();
        return Ok(lobby);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        
        var rotter = _service.GetLobby().FirstOrDefault(r => r.Id == id);
        if (rotter == null)
        {
            return NotFound(new { message = "L + Ratio + No Rotter Found" });
        }
        return Ok(rotter);
    }

    [HttpDelete("{id}")]
    public IActionResult Banish(int id)
    {
        _service.Banish(id);
        return Ok(new { message = "Sent to the shadow realm (Detroit)." });
    }
}
using HackathonEarthquake.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace HackathonEarthquake.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NeighbourhoodController : ControllerBase
{
    private readonly INeighbourhoodService _service;

    public NeighbourhoodController(INeighbourhoodService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var response = await _service.GetAllAsync();
        if (response.HasError)
            return BadRequest(response);
        return Ok(response);
    }
}
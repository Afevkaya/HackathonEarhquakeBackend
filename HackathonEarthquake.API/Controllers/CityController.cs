using HackathonEarthquake.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace HackathonEarthquake.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CityController : ControllerBase
{
    private readonly ICityService _service;

    public CityController(ICityService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var response = await _service.GetAllAsync();
        return Ok(response);
    }
}
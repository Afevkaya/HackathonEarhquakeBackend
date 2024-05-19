using HackathonEarthquake.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace HackathonEarthquake.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DistrictController : ControllerBase
{
    private readonly IDistrictService _service;

    public DistrictController(IDistrictService service)
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
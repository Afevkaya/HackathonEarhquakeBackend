using HackathonEarthquake.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace HackathonEarthquake.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MeetingPlaceController : ControllerBase
{
    private readonly IMeetingPlaceService _service;

    public MeetingPlaceController(IMeetingPlaceService service)
    {
        _service = service;
    }

    [HttpGet("{cityId}/{districtId}/{neighbourhoodId}")]
    public async Task<IActionResult> GetAsync(int cityId, int districtId, int neighbourhoodId)

    {
        var response = await _service.GetAsync(cityId, districtId, neighbourhoodId);
        if (response.HasError)
            return BadRequest(response);
        return Ok(response);
    }
}
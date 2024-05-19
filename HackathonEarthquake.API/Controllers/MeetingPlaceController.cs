using HackathonEarthquake.Core.DTOs.Request;
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
    
    [HttpPost]
    public async Task<IActionResult> Create(RequestCreateMeetingPlaceDto dto)
    {
        var response = await _service.AddAsync(dto);
        if (response.HasError)
            return BadRequest(response);
        return Ok(response);
    }
    
    [HttpPut("update")]
    public async Task<IActionResult> Create(RequestUpdateMeetingPlaceDto dto)
    {
        var response = await _service.UpdateAsync(dto);
        if (response.HasError)
            return BadRequest(response);
        return Ok(response);
    }
}
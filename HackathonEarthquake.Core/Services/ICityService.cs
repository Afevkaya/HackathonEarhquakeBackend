using HackathonEarthquake.Core.DTOs;
using HackathonEarthquake.Core.DTOs.Response;

namespace HackathonEarthquake.Core.Services;

public interface ICityService
{
    Task<BaseResponseDto<List<ResponseCityDto>>>GetAllAsync();
}
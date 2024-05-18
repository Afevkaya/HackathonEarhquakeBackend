using HackathonEarthquake.Core.DTOs.Response;

namespace HackathonEarthquake.Core.Services;

public interface ICityService
{
    Task<List<ResponseCityDtos>> GetAllAsync();
}
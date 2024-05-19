using HackathonEarthquake.Core.DTOs;
using HackathonEarthquake.Core.DTOs.Response;

namespace HackathonEarthquake.Core.Services;

public interface INeighbourhoodService
{
    Task<BaseResponseDto<List<NeighbourhoodDto>>> GetAllAsync();
}
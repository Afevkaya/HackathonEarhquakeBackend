using HackathonEarthquake.Core.DTOs;
using HackathonEarthquake.Core.DTOs.Response;

namespace HackathonEarthquake.Core.Services;

public interface IDistrictService
{
    Task<BaseResponseDto<List<ResponseDistrictDto>>> GetAllAsync();
}
using HackathonEarthquake.Core.DTOs;
using HackathonEarthquake.Core.DTOs.Response;

namespace HackathonEarthquake.Core.Services;

public interface IMeetingPlaceService
{
    Task<BaseResponseDto<List<ResponseMeetingPlaceDto>>> GetAsync(int cityId, int districtId, int neighbourhoodId);
}
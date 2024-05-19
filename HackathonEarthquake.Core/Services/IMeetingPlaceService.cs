using HackathonEarthquake.Core.DTOs;
using HackathonEarthquake.Core.DTOs.Request;
using HackathonEarthquake.Core.DTOs.Response;

namespace HackathonEarthquake.Core.Services;

public interface IMeetingPlaceService
{
    Task<BaseResponseDto<List<ResponseMeetingPlaceDto>>> GetAllAsync();
    Task<BaseResponseDto<List<ResponseMeetingPlaceDto>>> GetAsync(int cityId, int districtId, int neighbourhoodId);
    Task<BaseResponseDto<ResponseMeetingPlaceDto>> GetByIdAsync(int Id);
    Task<BaseResponseDto<ResponseMeetingPlaceDto>> AddAsync(RequestCreateMeetingPlaceDto dto);
    Task<BaseResponseDto<NoContentDto>> UpdateAsync(RequestUpdateMeetingPlaceDto dto);
}
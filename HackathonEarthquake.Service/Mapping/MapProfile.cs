using AutoMapper;
using HackathonEarthquake.Core.DTOs.Request;
using HackathonEarthquake.Core.DTOs.Response;
using HackathonEarthquake.Core.Entities;

namespace HackathonEarthquake.Service.Mapping;

public class MapProfile : Profile
{
    public MapProfile()
    {
        CreateMap<City, ResponseCityDto>();
        CreateMap<District, ResponseDistrictDto>();
        CreateMap<Neighbourhood, ResponseNeighbourhoodDto>();
        CreateMap<MeetingPlace, ResponseMeetingPlaceDto>();
        CreateMap<RequestCreateMeetingPlaceDto, MeetingPlace>();
    }
}
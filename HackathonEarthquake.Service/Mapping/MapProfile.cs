using AutoMapper;
using HackathonEarthquake.Core.DTOs.Request;
using HackathonEarthquake.Core.DTOs.Response;
using HackathonEarthquake.Core.Entities;

namespace HackathonEarthquake.Service.Mapping;

public class MapProfile : Profile
{
    public MapProfile()
    {
        CreateMap<City, ResponseCityDto>().ReverseMap();
        CreateMap<District, ResponseDistrictDto>().ReverseMap();
        CreateMap<Neighbourhood, ResponseNeighbourhoodDto>().ReverseMap();
        CreateMap<MeetingPlace, ResponseMeetingPlaceDto>().ReverseMap();
        CreateMap<RequestCreateMeetingPlaceDto, MeetingPlace>().ReverseMap();
    }
}
using AutoMapper;
using HackathonEarthquake.Core.DTOs.Response;
using HackathonEarthquake.Core.Entities;

namespace HackathonEarthquake.Service.Mapping;

public class MapProfile : Profile
{
    public MapProfile()
    {
        CreateMap<City, ResponseCityDtos>();
    }
}
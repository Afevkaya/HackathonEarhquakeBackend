using AutoMapper;
using HackathonEarthquake.Core.DTOs;
using HackathonEarthquake.Core.DTOs.Response;
using HackathonEarthquake.Core.Entities;
using HackathonEarthquake.Core.Repositories;
using HackathonEarthquake.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace HackathonEarthquake.Service.Services;

public class MeetingPlaceService : IMeetingPlaceService
{
    private readonly IMeetingPlaceRepository _repository;
    private readonly ICityRepository _cityRepository;
    private readonly IDistrictRepository _districtRepository;
    private readonly INeighbourhoodRepository _neighbourhoodRepository;
    private readonly IMapper _mapper;

    public MeetingPlaceService(
        IMeetingPlaceRepository repository, 
        ICityRepository cityRepository, 
        IDistrictRepository districtRepository, 
        INeighbourhoodRepository neighbourhoodRepository, 
        IMapper mapper)
    {
        _repository = repository;
        _cityRepository = cityRepository;
        _districtRepository = districtRepository;
        _neighbourhoodRepository = neighbourhoodRepository;
        _mapper = mapper;
    }

    public async Task<BaseResponseDto<List<ResponseMeetingPlaceDto>>> GetAsync(int cityId, int districtId, int neighbourhoodId)
    {
        var meetingPlaces = await _repository.Get(cityId, districtId, neighbourhoodId).ToListAsync();
        if (meetingPlaces is { Count: 0 })
            return BaseResponseDto<List<ResponseMeetingPlaceDto>>.Fail(404, "Toplanma Alanı Bulunamadı");

        var city = await _cityRepository.GetByIdAsync(cityId);
        var district = await _districtRepository.GetByIdAsync(districtId);
        var neighbourhood = await _neighbourhoodRepository.GetByIdAsync(neighbourhoodId);
        
        List<ResponseMeetingPlaceDto> response = new();
        meetingPlaces.ForEach(x =>
        {
            response.Add(new ResponseMeetingPlaceDto
            {
                Id = x.Id,
                CityName = city.Name,
                DistrictName = district.Name,
                NeighbourhoodName = neighbourhood.Name,
                TotalNumberOfBed = x.TotalNumberOfBed,
                OpenAddress = city.Name + " " + district.Name + " " + neighbourhood.Name + " " + x.OpenAddress,
                NumberOfBedUsed = x.NumberOfBedUsed,
                
                SolidityRatio = 100*x.NumberOfBedUsed / x.TotalNumberOfBed
            });
        });
        
        return BaseResponseDto<List<ResponseMeetingPlaceDto>>.Success(200, response);
    }
}
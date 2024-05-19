using AutoMapper;
using HackathonEarthquake.Core.DTOs;
using HackathonEarthquake.Core.DTOs.Request;
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

    public async Task<BaseResponseDto<List<ResponseMeetingPlaceDto>>> GetAllAsync()
    {
        var entities = await _repository.GetAll().ToListAsync();
        if (entities is { Count: 0 })
            return BaseResponseDto<List<ResponseMeetingPlaceDto>>.Fail(404, "Toplanma Alanları bulunamadı");
        
        
        
        List<ResponseMeetingPlaceDto> response = new();
        entities.ForEach(x =>
        {
            response.Add(new ResponseMeetingPlaceDto
            {
                Id = x.Id,
                Name = x.Name,
                CityName = _cityRepository.GetByIdAsync(x.CityId).Result.Name,
                DistrictName = _districtRepository.GetByIdAsync(x.DistrictId).Result.Name,
                NeighbourhoodName = _neighbourhoodRepository.GetByIdAsync(x.NeighbourhoodId).Result.Name,
                TotalNumberOfBed = x.TotalNumberOfBed,
                OpenAddress = x.OpenAddress,
                NumberOfBedUsed = x.NumberOfBedUsed,
                SolidityRatio = 100*x.NumberOfBedUsed / x.TotalNumberOfBed
            });
        });
        
        return BaseResponseDto<List<ResponseMeetingPlaceDto>>.Success(200, response);
    }
    public async Task<BaseResponseDto<ResponseMeetingPlaceDto>> GetByIdAsync(int Id)
    {
        var entity =await _repository.GetByIdAsync(Id);
        if (entity is null)
            return BaseResponseDto<ResponseMeetingPlaceDto>.Fail(404, "Toplanma Alanı Bulunamadı");

        var city = await _cityRepository.GetByIdAsync(entity.CityId);
        var district = await _districtRepository.GetByIdAsync(entity.DistrictId);
        var neighbourhood = await _neighbourhoodRepository.GetByIdAsync(entity.NeighbourhoodId);
        
        ResponseMeetingPlaceDto response = new();
        response = _mapper.Map<ResponseMeetingPlaceDto>(entity);
        response.CityName = city.Name;
        response.DistrictName = district.Name;
        response.NeighbourhoodName = neighbourhood.Name;
        response.SolidityRatio = 100 * response.NumberOfBedUsed / response.TotalNumberOfBed;
        response.OpenAddress = response.OpenAddress;
        
        return BaseResponseDto<ResponseMeetingPlaceDto>.Success(200, response);
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
                Name = x.Name,
                CityName = city.Name,
                DistrictName = district.Name,
                NeighbourhoodName = neighbourhood.Name,
                TotalNumberOfBed = x.TotalNumberOfBed,
                OpenAddress = x.OpenAddress,
                NumberOfBedUsed = x.NumberOfBedUsed,
                SolidityRatio = 100*x.NumberOfBedUsed / x.TotalNumberOfBed
            });
        });
        
        return BaseResponseDto<List<ResponseMeetingPlaceDto>>.Success(200, response);
    }
    
    public async Task<BaseResponseDto<ResponseMeetingPlaceDto>> AddAsync(RequestCreateMeetingPlaceDto dto)
    {
        if (dto is null)
            return BaseResponseDto<ResponseMeetingPlaceDto>.Fail(400, "Request datası boş");

        var entity = _mapper.Map<MeetingPlace>(dto);
        var result = await _repository.AddAsync(entity);
        if (result is null)
            return BaseResponseDto<ResponseMeetingPlaceDto>.Fail(500, "Sistemsel bir hata oluştu");

        var city = await _cityRepository.GetByIdAsync(entity.CityId);
        var district = await _districtRepository.GetByIdAsync(entity.DistrictId);
        var neighbourhood = await _neighbourhoodRepository.GetByIdAsync(entity.NeighbourhoodId);
        
        ResponseMeetingPlaceDto response = new();
        response = _mapper.Map<ResponseMeetingPlaceDto>(entity);
        response.CityName = city.Name;
        response.DistrictName = district.Name;
        response.NeighbourhoodName = neighbourhood.Name;
        response.SolidityRatio = 100 * response.NumberOfBedUsed / response.TotalNumberOfBed;
        response.OpenAddress = response.OpenAddress;
        return BaseResponseDto<ResponseMeetingPlaceDto>.Success(200, response);
    }

    public async Task<BaseResponseDto<NoContentDto>> UpdateAsync(RequestUpdateMeetingPlaceDto dto)
    {
        if (dto is { Id: 0 }) 
            return BaseResponseDto<NoContentDto>.Fail(400, "Request Datası boş");

        var entity = await _repository.GetByIdAsync(dto.Id);
        if (entity is null)
            return BaseResponseDto<NoContentDto>.Fail(404, "Toplanma Alanı Bulunamadı");

        entity.Name = dto.Name;
        entity.TotalNumberOfBed = dto.TotalNumberOfBed;
        entity.NumberOfBedUsed = dto.NumberOfBedUsed;
        await _repository.UpdateAsync(entity);
        return BaseResponseDto<NoContentDto>.Success(200);
    }
}
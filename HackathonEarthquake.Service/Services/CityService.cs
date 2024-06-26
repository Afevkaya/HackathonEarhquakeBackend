using AutoMapper;
using HackathonEarthquake.Core.DTOs;
using HackathonEarthquake.Core.DTOs.Response;
using HackathonEarthquake.Core.Repositories;
using HackathonEarthquake.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace HackathonEarthquake.Service.Services;

public class CityService : ICityService
{
    private readonly ICityRepository _repository;
    private readonly IMapper _mapper;

    public CityService(ICityRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<BaseResponseDto<List<ResponseCityDto>> >GetAllAsync()
    {
        var cities = await _repository.GetAll().ToListAsync();
        if (cities is { Count: 0 })
            return BaseResponseDto<List<ResponseCityDto>>.Fail(404, "Şehir Bulunamadı");

        var dtos = _mapper.Map<List<ResponseCityDto>>(cities);
        return BaseResponseDto<List<ResponseCityDto>>.Success(200, dtos);
    }
}
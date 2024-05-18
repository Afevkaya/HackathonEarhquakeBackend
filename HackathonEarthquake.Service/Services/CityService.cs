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

    public async Task<BaseResponseDto<List<ResponseCityDtos>> >GetAllAsync()
    {
        var entites = await _repository.GetAll().ToListAsync();
        if (entites is { Count: 0 })
        {
            return BaseResponseDto<List<ResponseCityDtos>>.Fail(404, "Şehir Bulunamadı");
        }

        var dtos = _mapper.Map<List<ResponseCityDtos>>(entites);
        return BaseResponseDto<List<ResponseCityDtos>>.Success(200, dtos);
    }
}
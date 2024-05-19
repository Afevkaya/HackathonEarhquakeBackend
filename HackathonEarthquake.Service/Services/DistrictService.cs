using AutoMapper;
using HackathonEarthquake.Core.DTOs;
using HackathonEarthquake.Core.DTOs.Response;
using HackathonEarthquake.Core.Repositories;
using HackathonEarthquake.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace HackathonEarthquake.Service.Services;

public class DistrictService : IDistrictService
{
    private readonly IDistrictRepository _repository;
    private readonly IMapper _mapper;

    public DistrictService(IDistrictRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<BaseResponseDto<List<ResponseDistrictDto>>> GetAllAsync()
    {
        var districts = await _repository.GetAll().ToListAsync();
        if (districts is { Count: 0 })
            return BaseResponseDto<List<ResponseDistrictDto>>.Fail(404, "İlçe Bulunamadı");

        var dtos = _mapper.Map<List<ResponseDistrictDto>>(districts);
        return BaseResponseDto<List<ResponseDistrictDto>>.Success(200, dtos);
    }
}
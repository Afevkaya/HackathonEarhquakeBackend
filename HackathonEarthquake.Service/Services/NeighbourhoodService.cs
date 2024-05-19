using AutoMapper;
using HackathonEarthquake.Core.DTOs;
using HackathonEarthquake.Core.DTOs.Response;
using HackathonEarthquake.Core.Repositories;
using HackathonEarthquake.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace HackathonEarthquake.Service.Services;

public class NeighbourhoodService : INeighbourhoodService
{
    private readonly INeighbourhoodRepository _repository;
    private readonly IMapper _mapper;

    public NeighbourhoodService(INeighbourhoodRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<BaseResponseDto<List<NeighbourhoodDto>>> GetAllAsync()
    {
        var neighboors = await _repository.GetAll().ToListAsync();
        if (neighboors is { Count: 0 })
            return BaseResponseDto<List<NeighbourhoodDto>>.Fail(404, "Mahalle Bulunamadı");

        var dtos = _mapper.Map<List<NeighbourhoodDto>>(neighboors);
        return BaseResponseDto<List<NeighbourhoodDto>>.Success(200, dtos);

    }
}
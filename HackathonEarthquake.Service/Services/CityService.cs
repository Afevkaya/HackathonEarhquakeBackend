using HackathonEarthquake.Core.DTOs.Response;
using HackathonEarthquake.Core.Repositories;
using HackathonEarthquake.Core.Services;
using Microsoft.EntityFrameworkCore;

namespace HackathonEarthquake.Service.Services;

public class CityService : ICityService
{
    private readonly ICityRepository _repository;

    public CityService(ICityRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<ResponseCityDtos>> GetAllAsync()
    {
        var entites = await _repository.GetAll().ToListAsync();
        List<ResponseCityDtos> dtosList = new();
        entites.ForEach(c =>
        {
            dtosList.Add(new ResponseCityDtos { Id = c.Id, Name = c.Name });
        });
        return dtosList;
    }
}
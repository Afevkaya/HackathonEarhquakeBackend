using HackathonEarthquake.Core.Entities;

namespace HackathonEarthquake.Core.Repositories;

public interface ICityRepository
{
    IQueryable<City> GetAll();
    Task<City> GetByIdAsync(int Id);
}
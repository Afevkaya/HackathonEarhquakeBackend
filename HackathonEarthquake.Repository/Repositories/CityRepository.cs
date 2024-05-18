using HackathonEarthquake.Core.Entities;
using HackathonEarthquake.Core.Repositories;
using HackathonEarthquake.Repository.Context;

namespace HackathonEarthquake.Repository.Repositories;

public class CityRepository : ICityRepository
{
    private readonly EarthquakeDbContext _dbContext;

    public CityRepository(EarthquakeDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IQueryable<City> GetAll()
    {
        return _dbContext.Cities.AsQueryable();
    }
}
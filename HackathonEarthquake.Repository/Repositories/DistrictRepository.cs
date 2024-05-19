using HackathonEarthquake.Core.Entities;
using HackathonEarthquake.Core.Repositories;
using HackathonEarthquake.Repository.Context;

namespace HackathonEarthquake.Repository.Repositories;

public class DistrictRepository : IDistrictRepository
{
    private readonly EarthquakeDbContext _dbContext;

    public DistrictRepository(EarthquakeDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IQueryable<District> GetAll()
    {
        return _dbContext.Districts.AsQueryable();
    }
}
using HackathonEarthquake.Core.Entities;
using HackathonEarthquake.Core.Repositories;
using HackathonEarthquake.Repository.Context;

namespace HackathonEarthquake.Repository.Repositories;

public class NeighbourhoodRepository : INeighbourhoodRepository
{
    private readonly EarthquakeDbContext _context;

    public NeighbourhoodRepository(EarthquakeDbContext context)
    {
        _context = context;
    }

    public IQueryable<Neighbourhood> GetAll()
    {
        return _context.Neighbourhoods.AsQueryable();
    }

    public async Task<Neighbourhood> GetByIdAsync(int Id)
    {
        return await _context.Neighbourhoods.FindAsync(Id);
    }
}
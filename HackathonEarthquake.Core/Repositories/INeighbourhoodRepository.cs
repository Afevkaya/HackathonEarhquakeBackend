using HackathonEarthquake.Core.Entities;

namespace HackathonEarthquake.Core.Repositories;

public interface INeighbourhoodRepository
{
    IQueryable<Neighbourhood> GetAll();
    Task<Neighbourhood> GetByIdAsync(int Id);
}
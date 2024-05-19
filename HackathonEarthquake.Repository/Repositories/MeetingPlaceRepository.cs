using HackathonEarthquake.Core.Entities;
using HackathonEarthquake.Core.Repositories;
using HackathonEarthquake.Repository.Context;

namespace HackathonEarthquake.Repository.Repositories;

public class MeetingPlaceRepository : IMeetingPlaceRepository
{
    private readonly EarthquakeDbContext _context;

    public MeetingPlaceRepository(EarthquakeDbContext context)
    {
        _context = context;
    }

    public IQueryable<MeetingPlace> Get(int cityId, int districtId, int neighbourhoodId)
    {
        return _context.MeetingPlaces
            .Where(m => m.CityId == cityId && m.DistrictId == districtId && m.NeighbourhoodId == neighbourhoodId);
    }
}
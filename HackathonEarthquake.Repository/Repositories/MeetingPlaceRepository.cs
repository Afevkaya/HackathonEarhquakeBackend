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

    public IQueryable<MeetingPlace> GetAll()
    {
        return _context.MeetingPlaces.AsQueryable();
    }
    
    public async Task<MeetingPlace> GetByIdAsync(int Id)
    {
        return await _context.MeetingPlaces.FindAsync(Id);
    }
    
    public IQueryable<MeetingPlace> Get(int cityId, int districtId, int neighbourhoodId)
    {
        return _context.MeetingPlaces
            .Where(m => m.CityId == cityId && m.DistrictId == districtId && m.NeighbourhoodId == neighbourhoodId);
    }


    public async Task<MeetingPlace> AddAsync(MeetingPlace meetingPlace)
    {
        await _context.MeetingPlaces.AddAsync(meetingPlace);
        await _context.SaveChangesAsync();
        return meetingPlace;
    }

    public async Task UpdateAsync(MeetingPlace meetingPlace)
    {
        _context.Update(meetingPlace);
        await _context.SaveChangesAsync();
    }
}
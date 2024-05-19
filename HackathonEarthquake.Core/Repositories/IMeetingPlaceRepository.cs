using HackathonEarthquake.Core.Entities;

namespace HackathonEarthquake.Core.Repositories;

public interface IMeetingPlaceRepository
{
    IQueryable<MeetingPlace> Get(int cityId, int districtId, int neighbourhoodId);
    Task<MeetingPlace> GetByIdAsync(int Id);
    Task<MeetingPlace> AddAsync(MeetingPlace meetingPlace);
    Task UpdateAsync(MeetingPlace meetingPlace);
}
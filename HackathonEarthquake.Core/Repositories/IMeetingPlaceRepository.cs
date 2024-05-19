using HackathonEarthquake.Core.Entities;

namespace HackathonEarthquake.Core.Repositories;

public interface IMeetingPlaceRepository
{
    IQueryable<MeetingPlace> GetAll();
    Task<MeetingPlace> GetByIdAsync(int Id);
    IQueryable<MeetingPlace> Get(int cityId, int districtId, int neighbourhoodId);
    Task<MeetingPlace> AddAsync(MeetingPlace meetingPlace);
    Task UpdateAsync(MeetingPlace meetingPlace);
}
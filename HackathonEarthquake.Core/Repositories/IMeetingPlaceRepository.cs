using HackathonEarthquake.Core.Entities;

namespace HackathonEarthquake.Core.Repositories;

public interface IMeetingPlaceRepository
{
    IQueryable<MeetingPlace> Get(int cityId, int districtId, int neighbourhoodId);
}
using HackathonEarthquake.Core.Entities;

namespace HackathonEarthquake.Core.Repositories;

public interface IDistrictRepository
{
    IQueryable<District> GetAll();
}
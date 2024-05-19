namespace HackathonEarthquake.Core.Entities;

public class MeetingPlace : BaseEntity
{
    public int TotalNumberOfBed { get; set; }
    public int NumberOfBedUsed { get; set; }
    public int CityId { get; set; }
    public int DistrictId { get; set; }
    public int NeighbourhoodId { get; set; }
    public string OpenAddress { get; set; }
}
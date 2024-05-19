namespace HackathonEarthquake.Core.DTOs.Request;

public class RequestCreateMeetingPlaceDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int TotalNumberOfBed { get; set; }
    public int NumberOfBedUsed { get; set; }
    public int CityId { get; set; }
    public int DistrictId { get; set; }
    public int NeighbourhoodId { get; set; }
    public string OpenAddress { get; set; }
}
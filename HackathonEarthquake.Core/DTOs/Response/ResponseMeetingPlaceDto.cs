namespace HackathonEarthquake.Core.DTOs.Response;

public class ResponseMeetingPlaceDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int TotalNumberOfBed { get; set; }
    public int NumberOfBedUsed { get; set; }
    public string OpenAddress { get; set; }
    public string CityName { get; set; }
    public string DistrictName { get; set; }
    public string NeighbourhoodName { get; set; }
    public double SolidityRatio { get; set; } 
}
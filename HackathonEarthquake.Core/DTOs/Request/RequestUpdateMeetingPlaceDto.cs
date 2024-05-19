namespace HackathonEarthquake.Core.DTOs.Request;

public class RequestUpdateMeetingPlaceDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int TotalNumberOfBed { get; set; }
    public int NumberOfBedUsed { get; set; }
}
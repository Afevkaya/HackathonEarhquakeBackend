namespace HackathonEarthquake.Core.Entities;

public class Neighbourhood
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int DistrictId { get; set; }
    public District District { get; set; }
}
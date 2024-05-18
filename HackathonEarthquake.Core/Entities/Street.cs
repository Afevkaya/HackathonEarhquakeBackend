namespace HackathonEarthquake.Core.Entities;

public class Street
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int NeighbourhoodId { get; set; }
    public Neighbourhood Neighbourhood { get; set; }
}
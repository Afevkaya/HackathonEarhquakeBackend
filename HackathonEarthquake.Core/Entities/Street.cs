namespace HackathonEarthquake.Core.Entities;

public class Street : BaseEntity
{
    public int NeighbourhoodId { get; set; }
    public Neighbourhood Neighbourhood { get; set; }
}
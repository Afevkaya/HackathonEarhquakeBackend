namespace HackathonEarthquake.Core.Entities;

public class District : BaseEntity
{
    public int CityId { get; set; }
    public City City { get; set; }
    public ICollection<Neighbourhood> Neighbourhoods { get; set; }
}
namespace HackathonEarthquake.Core.Entities;

public class Neighbourhood : BaseEntity
{
    public int DistrictId { get; set; }
    public District District { get; set; }
    public ICollection<Street> Streets { get; set; }
}
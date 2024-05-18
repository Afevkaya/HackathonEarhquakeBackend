namespace HackathonEarthquake.Core.Entities;

public class City : BaseEntity
{
    public ICollection<District> Districts { get; set; }
}
using HackathonEarthquake.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HackathonEarthquake.Repository.Seeds;

public class NeighbourhoodSeed : IEntityTypeConfiguration<Neighbourhood>
{
    public void Configure(EntityTypeBuilder<Neighbourhood> builder)
    {
        builder.HasData(
            new Neighbourhood
            {
                Id = 1,
                Name = "ÇırÇır",
                DistrictId = 1
            });
    }
}
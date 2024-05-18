using HackathonEarthquake.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HackathonEarthquake.Repository.Seeds;

public class StreetSeed : IEntityTypeConfiguration<Street>
{
    public void Configure(EntityTypeBuilder<Street> builder)
    {
        builder.HasData(
            new Street
            {
                Id = 1,
                Name = "Funda",
                NeighbourhoodId = 1
            });
    }
}
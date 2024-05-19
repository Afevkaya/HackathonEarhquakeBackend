using HackathonEarthquake.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HackathonEarthquake.Repository.Seeds;

public class DistrictSeed : IEntityTypeConfiguration<District>
{
    public void Configure(EntityTypeBuilder<District> builder)
    {
        builder.HasData(
            new District
            {
                Id = 1,
                Name = "Eyüp",
                CityId = 1
            },
            new District
            {
                Id = 2,
                Name = "Ümraniye",
                CityId = 1
            });
    }
}
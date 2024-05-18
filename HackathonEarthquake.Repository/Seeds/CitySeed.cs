using HackathonEarthquake.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HackathonEarthquake.Repository.Seeds;

public class CitySeed : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder.HasData(
            new City
            {
                Id = 1,
                Name = "İstanbul"
            });
    }
}
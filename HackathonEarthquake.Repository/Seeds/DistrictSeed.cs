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
                City = new City
                {
                    Id = 1,
                    Name = "İstanbul"
                },
                CityId = 1
            },
            new District
            {
                Id = 2,
                Name = "Ümraniye",
                City = new City
                {
                    Id = 1,
                    Name = "İstanbul"
                },
                CityId = 1 
            });
    }
}
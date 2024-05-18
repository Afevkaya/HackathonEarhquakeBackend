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
                District = new District
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
                DistrictId = 1
            },
            new Neighbourhood
            {
                Id = 2,
                Name = "Çakmak",
                District = new District
                {
                    Id = 2,
                    Name = "Ümraniye",
                    City = new City
                    {
                        Id = 1,
                        Name = "İstanbul"
                    },
                    CityId = 1
                },
                DistrictId = 2
            });
    }
}
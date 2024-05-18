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
                Neighbourhood = new Neighbourhood
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
                NeighbourhoodId = 1
            },
            new Street
            {
                Id = 2,
                Name = "Yenigün",
                Neighbourhood = new Neighbourhood
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
                },
                NeighbourhoodId = 2
            });
    }
}
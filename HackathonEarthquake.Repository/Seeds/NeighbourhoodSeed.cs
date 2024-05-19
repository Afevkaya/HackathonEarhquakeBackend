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
                Name = "Çırçır",
                DistrictId = 1
            },
            new Neighbourhood
            {
                Id = 2,
                Name = "Karadolap",
                DistrictId = 1
            },new Neighbourhood
            {
                Id = 3,
                Name = "Çakmak",
                DistrictId = 2
            },
            new Neighbourhood
            {
                Id = 4,
                Name = "Çamlık",
                DistrictId = 2
            });
    }
}
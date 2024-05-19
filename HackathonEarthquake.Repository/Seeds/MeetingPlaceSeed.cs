using HackathonEarthquake.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HackathonEarthquake.Repository.Seeds;

public class MeetingPlaceSeed : IEntityTypeConfiguration<MeetingPlace>
{
    public void Configure(EntityTypeBuilder<MeetingPlace> builder)
    {
        builder.HasData(
            new MeetingPlace
            {
                Id = 1,
                Name = "Çırçır Toplanma Alanı",
                CityId = 1,
                DistrictId = 1,
                NeighbourhoodId = 1,
                TotalNumberOfBed = 150,
                NumberOfBedUsed = 100,
                OpenAddress = "Çırçır Mahallesi Funda Sokak Eyüp/İstanbul"
            },
            new MeetingPlace
            {
                Id = 2,
                Name = "Karadolap Toplanma Alanı",
                CityId = 1,
                DistrictId = 1,
                NeighbourhoodId = 1,
                TotalNumberOfBed = 175,
                NumberOfBedUsed = 75,
                OpenAddress = "Karadolap Mahallesi Bilmiyom Sokak Eyüp/İstanbul"
            },new MeetingPlace
            {
                Id = 3,
                Name = "Çakmak Toplanma Alanı",
                CityId = 1,
                DistrictId = 2,
                NeighbourhoodId = 3,
                TotalNumberOfBed = 75,
                NumberOfBedUsed = 55,
                OpenAddress = "Çakmak Mahallesi Yenigün Sokak Ümraniye/İstanbul"
            },
            new MeetingPlace
            {
                Id = 4,
                Name = "Çamlık Toplanma Alanı",
                CityId = 1,
                DistrictId = 2,
                NeighbourhoodId = 4,
                TotalNumberOfBed = 125,
                NumberOfBedUsed = 95,
                OpenAddress = "Çamlık Mahallesi Bilmiyomiki Sokak Ümraniye/İstanbul"
            });
    }
}
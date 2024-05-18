﻿// <auto-generated />
using HackathonEarthquake.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HackathonEarthquake.Repository.Migrations
{
    [DbContext(typeof(EarthquakeDbContext))]
    [Migration("20240518204539_Relation")]
    partial class Relation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HackathonEarthquake.Core.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "İstanbul"
                        });
                });

            modelBuilder.Entity("HackathonEarthquake.Core.Entities.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Districts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            Name = "Eyüp"
                        });
                });

            modelBuilder.Entity("HackathonEarthquake.Core.Entities.Neighbourhood", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DistrictId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DistrictId");

                    b.ToTable("Neighbourhoods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DistrictId = 1,
                            Name = "ÇırÇır"
                        });
                });

            modelBuilder.Entity("HackathonEarthquake.Core.Entities.Street", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NeighbourhoodId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NeighbourhoodId");

                    b.ToTable("Streets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Funda",
                            NeighbourhoodId = 1
                        });
                });

            modelBuilder.Entity("HackathonEarthquake.Core.Entities.District", b =>
                {
                    b.HasOne("HackathonEarthquake.Core.Entities.City", "City")
                        .WithMany("Districts")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("HackathonEarthquake.Core.Entities.Neighbourhood", b =>
                {
                    b.HasOne("HackathonEarthquake.Core.Entities.District", "District")
                        .WithMany("Neighbourhoods")
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("District");
                });

            modelBuilder.Entity("HackathonEarthquake.Core.Entities.Street", b =>
                {
                    b.HasOne("HackathonEarthquake.Core.Entities.Neighbourhood", "Neighbourhood")
                        .WithMany("Streets")
                        .HasForeignKey("NeighbourhoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Neighbourhood");
                });

            modelBuilder.Entity("HackathonEarthquake.Core.Entities.City", b =>
                {
                    b.Navigation("Districts");
                });

            modelBuilder.Entity("HackathonEarthquake.Core.Entities.District", b =>
                {
                    b.Navigation("Neighbourhoods");
                });

            modelBuilder.Entity("HackathonEarthquake.Core.Entities.Neighbourhood", b =>
                {
                    b.Navigation("Streets");
                });
#pragma warning restore 612, 618
        }
    }
}

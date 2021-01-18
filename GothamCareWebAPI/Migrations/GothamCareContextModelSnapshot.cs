﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using charitableLibrary.Models;

namespace charitableLibrary.Migrations
{
    [DbContext(typeof(GothamCareContext))]
    partial class GothamCareContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("charitableLibrary.Models.Outlet", b =>
                {
                    b.Property<string>("OutletID")
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Landmark")
                        .HasColumnType("text");

                    b.Property<int>("NumberOfAvailableFoodPacks")
                        .HasColumnType("integer");

                    b.Property<int>("NumberOfVolunteersRequired")
                        .HasColumnType("integer");

                    b.Property<string>("OutletName")
                        .HasColumnType("text");

                    b.Property<string>("StreetName")
                        .HasColumnType("text");

                    b.Property<string>("TypeOfFood")
                        .HasColumnType("text");

                    b.HasKey("OutletID");

                    b.ToTable("outlets");
                });

            modelBuilder.Entity("charitableLibrary.Models.Volunteer", b =>
                {
                    b.Property<string>("VolunteerID")
                        .HasColumnType("text");

                    b.Property<string>("OutletID")
                        .HasColumnType("text");

                    b.Property<string>("VolunteerAddress")
                        .HasColumnType("text");

                    b.Property<string>("VolunteerEmail")
                        .HasColumnType("text");

                    b.Property<int>("VolunteerPhoneNumber")
                        .HasColumnType("integer");

                    b.Property<string>("VoluteerName")
                        .HasColumnType("text");

                    b.HasKey("VolunteerID");

                    b.ToTable("volunteers");
                });
#pragma warning restore 612, 618
        }
    }
}

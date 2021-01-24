﻿// <auto-generated />
using System;
using DataServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataServices.Migrations
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

            modelBuilder.Entity("DataServices.Models.Admin", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Email");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("DataServices.Models.Outlet", b =>
                {
                    b.Property<int>("OutletID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Landmark")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NumberOfAvailableFoodPacks")
                        .HasColumnType("integer");

                    b.Property<int>("NumberOfVolunteersRequired")
                        .HasColumnType("integer");

                    b.Property<string>("OutletName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TypeOfFood")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("OutletID");

                    b.ToTable("Outlet");
                });

            modelBuilder.Entity("DataServices.Models.Volunteer", b =>
                {
                    b.Property<int>("VolunteerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("OutletID")
                        .HasColumnType("integer");

                    b.Property<string>("VolunteerAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("VolunteerEmail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("VolunteerName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("VolunteerPhonenumber")
                        .HasColumnType("integer");

                    b.HasKey("VolunteerID");

                    b.ToTable("Volunteer");
                });
#pragma warning restore 612, 618
        }
    }
}

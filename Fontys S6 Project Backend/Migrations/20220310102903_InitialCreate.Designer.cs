﻿// <auto-generated />
using Fontys_S6_Project_Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Fontys_S6_Project_Backend.Migrations
{
    [DbContext(typeof(HotelContext))]
    [Migration("20220310102903_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Fontys_S6_Project_Backend.Models.Room", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RoomID"));

                    b.Property<bool>("RoomOccupied")
                        .HasColumnType("boolean");

                    b.Property<int>("RoomSize")
                        .HasColumnType("integer");

                    b.HasKey("RoomID");

                    b.ToTable("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}

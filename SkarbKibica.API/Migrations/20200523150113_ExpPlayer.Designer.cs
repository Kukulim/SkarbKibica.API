﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SkarbKibica.API.DbContexts;

namespace SkarbKibica.API.Migrations
{
    [DbContext(typeof(SkarbKibicaDbContext))]
    [Migration("20200523150113_ExpPlayer")]
    partial class ExpPlayer
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SkarbKibica.API.Entities.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BirthPlace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamSquadId")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamSquadId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("SkarbKibica.API.Entities.Stadium", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("Seats")
                        .HasColumnType("int")
                        .HasMaxLength(100);

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId")
                        .IsUnique();

                    b.ToTable("Stadiums");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adress = "Czerwono-niebieskie",
                            Name = "Miejski Stadion Piłkarski",
                            Seats = 4200,
                            TeamId = 1
                        },
                        new
                        {
                            Id = 2,
                            Adress = "Sabinowska 11/23",
                            Name = "Stadion Piłkarski",
                            Seats = 960,
                            TeamId = 2
                        },
                        new
                        {
                            Id = 3,
                            Adress = "Rychlińskiego 21",
                            Name = "Stadion Miejski",
                            Seats = 15316,
                            TeamId = 3
                        });
                });

            modelBuilder.Entity("SkarbKibica.API.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClubColors")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Created")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClubColors = "Czerwono-niebieskie",
                            Created = 1921,
                            Name = "Raków Częstochowa"
                        },
                        new
                        {
                            Id = 2,
                            ClubColors = "Biało-bordowe",
                            Created = 1934,
                            Name = "Klub Sportowy Częstochowa"
                        },
                        new
                        {
                            Id = 3,
                            ClubColors = "Czerwono-biało-niebieskie",
                            Created = 1995,
                            Name = "TS Podbeskidzie Spółka Akcyjna"
                        });
                });

            modelBuilder.Entity("SkarbKibica.API.Entities.TeamSquad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Season")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("TeamSquads");
                });

            modelBuilder.Entity("SkarbKibica.API.Entities.Player", b =>
                {
                    b.HasOne("SkarbKibica.API.Entities.TeamSquad", "TeamSquad")
                        .WithMany("Players")
                        .HasForeignKey("TeamSquadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SkarbKibica.API.Entities.Stadium", b =>
                {
                    b.HasOne("SkarbKibica.API.Entities.Team", null)
                        .WithOne("Stadium")
                        .HasForeignKey("SkarbKibica.API.Entities.Stadium", "TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SkarbKibica.API.Entities.TeamSquad", b =>
                {
                    b.HasOne("SkarbKibica.API.Entities.Team", "Team")
                        .WithMany("TeamSquads")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
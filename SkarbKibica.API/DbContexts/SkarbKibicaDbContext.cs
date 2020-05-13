using Microsoft.EntityFrameworkCore;
using SkarbKibica.API.Entities;

namespace SkarbKibica.API.DbContexts
{
    public class SkarbKibicaDbContext : DbContext
    {
        public SkarbKibicaDbContext(DbContextOptions<SkarbKibicaDbContext> options)
            : base(options)
        {
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Stadium> Stadiums { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(
                new Team()
                {
                    Id = 1,
                    Name = "Raków Częstochowa",
                    ClubColors = "Czerwono-niebieskie",
                    Created = 1921
                },
                new Team()
                {
                    Id = 2,
                    Name = "Klub Sportowy Częstochowa",
                    ClubColors = "Biało-bordowe",
                    Created = 1934
                },
                new Team()
                {
                    Id = 3,
                    Name = "TS Podbeskidzie Spółka Akcyjna",
                    ClubColors = "Czerwono-biało-niebieskie",
                    Created = 1995
                }
                );
            modelBuilder.Entity<Stadium>().HasData(
                new Stadium()
                {
                    Id = 1,
                    Name = "Miejski Stadion Piłkarski",
                    Adress = "Czerwono-niebieskie",
                    Seats = 4200,
                    TeamId = 1
                },
                new Stadium()
                {
                    Id = 2,
                    Name = "Stadion Piłkarski",
                    Adress = "Sabinowska 11/23",
                    Seats = 960,
                    TeamId = 2
                },
                new Stadium()
                {
                    Id = 3,
                    Name = "Stadion Miejski",
                    Adress = "Rychlińskiego 21",
                    Seats = 15316,
                    TeamId = 3
                }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
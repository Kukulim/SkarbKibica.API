using SkarbKibica.API.DbContexts;
using SkarbKibica.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SkarbKibica.API.Services
{
    public class StadiumRepository : IStadiumRepository
    {
        private readonly SkarbKibicaDbContext context;

        public StadiumRepository(SkarbKibicaDbContext _context)
        {
            this.context = _context;
        }

        public void AddStadium(Stadium stadium)
        {
            context.Stadiums.Add(stadium);
        }

        public void Compleate()
        {
            context.SaveChanges();
        }

        public void DeleteStadium(Stadium stadium)
        {
            throw new NotImplementedException();
        }

        public Stadium GetStadium(int stadiumId)
        {
            return context.Stadiums.Where(s => s.Id == stadiumId).FirstOrDefault();
        }

        public IEnumerable<Stadium> GetStadiums()
        {
            return context.Stadiums.ToList();
        }

        public void UpdateStadium(Stadium stadium)
        {
            throw new NotImplementedException();
        }
    }
}
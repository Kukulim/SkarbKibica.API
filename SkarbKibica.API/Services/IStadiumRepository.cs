using SkarbKibica.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkarbKibica.API.Services
{
    public interface IStadiumRepository
    {
        IEnumerable<Stadium> GetStadiums();
        Stadium GetStadium(int stadiumId);
        void AddStadium(Stadium stadium);
        void UpdateStadium(Stadium stadium);
        void DeleteStadium(Stadium stadium);

    }
}

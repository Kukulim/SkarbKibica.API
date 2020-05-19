using AutoMapper;
using SkarbKibica.API.Dtos.TeamSquadsDtos;
using SkarbKibica.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SkarbKibica.API.AutoMaperProfiles
{
    public class TeamSquadProfile : Profile
    {
        public TeamSquadProfile()
        {
            CreateMap<TeamSquad, TeamSquadDto>();
        }
    }
}

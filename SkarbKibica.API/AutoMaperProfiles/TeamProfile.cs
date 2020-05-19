using AutoMapper;
using SkarbKibica.API.Dtos;
using SkarbKibica.API.Dtos.StadiumDtos;
using SkarbKibica.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkarbKibica.API.AutoMaperProfiles
{
    public class TeamProfile : Profile
    {
        public TeamProfile()
        {
            CreateMap<Team, TeamDto>();
            CreateMap<TeamCreationDto, Team>();
            CreateMap<Team, TeamCreationDto>();
        }
    }
}

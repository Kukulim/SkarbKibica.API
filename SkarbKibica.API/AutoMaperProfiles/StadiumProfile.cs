using AutoMapper;
using SkarbKibica.API.Dtos;
using SkarbKibica.API.Dtos.StadiumDtos;
using SkarbKibica.API.Dtos.StadiumDtos.TeamDtos;
using SkarbKibica.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkarbKibica.API.AutoMaperProfiles
{
    public class StadiumProfile :Profile
    {
        public StadiumProfile()
        {
            CreateMap<Stadium, StadiumDto>();
            CreateMap<StadiumCreationDto, Stadium>();
            CreateMap<Stadium, StadiumCreationDto>();
        }
    }
}

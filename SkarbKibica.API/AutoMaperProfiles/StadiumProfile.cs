using AutoMapper;
using SkarbKibica.API.Dtos;
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
        }
    }
}

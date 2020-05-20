using AutoMapper;
using SkarbKibica.API.Dtos.PlayerDtos;
using SkarbKibica.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkarbKibica.API.AutoMaperProfiles
{
    public class PlayerProfile : Profile
    {
        public PlayerProfile()
        {
            CreateMap<Player, PlayerDto>();
            CreateMap<PlayerCreationDto, Player>();
            CreateMap<Player, PlayerCreationDto>();
        }
    }
}

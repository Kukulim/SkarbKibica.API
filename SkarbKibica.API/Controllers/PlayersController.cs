using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkarbKibica.API.Dtos.PlayerDtos;
using SkarbKibica.API.Services;

namespace SkarbKibica.API.Controllers
{
    [Route("api/teams/{teamId}/TeamSquads/{teamSquadId}/players")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayerRepository playerRepository;
        private readonly IMapper mapper;

        public PlayersController(IPlayerRepository playerRepository, IMapper mapper)
        {
            this.playerRepository = playerRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllPlayers(int  teamSquadId)
        {
            var playersFromRepo = playerRepository.GetPlayers(teamSquadId);

            return Ok(mapper.Map<IEnumerable<PlayerDto>>(playersFromRepo));
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkarbKibica.API.Dtos.PlayerDtos;
using SkarbKibica.API.Entities;
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

        [HttpGet("{playerId}", Name = "GetPlayer")]
        public IActionResult GetPlayer(int teamSquadId ,int playerId)
        {
            var playersFromRepo = playerRepository.GetPlayer(teamSquadId, playerId);

            if (playersFromRepo == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<PlayerDto>(playersFromRepo));
        }

        [HttpPost]
        public ActionResult CreatePlayer(int teamSquadId, PlayerCreationDto player)
        {
            var playerEntity = mapper.Map<Player>(player);

            playerRepository.AddPlayer(teamSquadId, playerEntity);
            playerRepository.Compleate();

            return Ok();
        }

        [HttpPut("{playerId}")]
        public ActionResult UpdatePlayer(int teamSquadId, int playerId, [FromBody] PlayerCreationDto player)
        {
            var playersFromRepo = playerRepository.GetPlayer(teamSquadId, playerId);

            if (playersFromRepo == null)
            {
                return NotFound();
            }

            mapper.Map(player, playersFromRepo);

            playerRepository.UpdatePlayer(playersFromRepo);
            playerRepository.Compleate();

            return NoContent();
        }

        [HttpDelete("{playerId}")]
        public ActionResult DeletePlayer(int teamSquadId, int playerId)
        {
            var playersFromRepo = playerRepository.GetPlayer(teamSquadId, playerId);

            if (playersFromRepo == null)
            {
                return NotFound();
            }

            playerRepository.DeletePlayer(playersFromRepo);
            playerRepository.Compleate();

            return NoContent();
        }
    }
}
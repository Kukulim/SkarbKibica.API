using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkarbKibica.API.Dtos.TeamSquadsDtos;
using SkarbKibica.API.Entities;
using SkarbKibica.API.Services;

namespace SkarbKibica.API.Controllers
{
    [Route("api/teams/{teamId}/TeamSquads")]
    [ApiController]
    public class TeamsSquadsController : ControllerBase
    {
        private readonly ITeamSquadsRepository teamSquadsRepository;
        private readonly IMapper mapper;

        public TeamsSquadsController(ITeamSquadsRepository teamSquadsRepository, IMapper mapper)
        {
            this.teamSquadsRepository = teamSquadsRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllTeamsSquads(int teamId)
        {
            var teamsSquadFromTeamFromRepo = teamSquadsRepository.GetTeamSquads(teamId);

            return Ok(mapper.Map<IEnumerable<TeamSquadDto>>(teamsSquadFromTeamFromRepo));
        }

        [HttpGet("{teamSquadId}", Name = "GetTeamSquadFromTeam")]
        public IActionResult GetTeamSquad(int teamId, int teamSquadId)
        {
            var teamSquadFromTeamFromRepo = teamSquadsRepository.GetTeamSquad(teamId, teamSquadId);
            return Ok(mapper.Map<TeamSquadDto>(teamSquadFromTeamFromRepo));
        }

        [HttpPost]
        public ActionResult CreateTeamSquadForTeam(
            int teamId, TeamSquadCreationDto teamSquad)
        {
            var teamSquadEntity = mapper.Map<TeamSquad>(teamSquad);
            teamSquadsRepository.AddTeamSquad(teamId, teamSquadEntity);
            teamSquadsRepository.Compleate();

            var teamSquadToReturn = mapper.Map<TeamSquadDto>(teamSquadEntity);

            return CreatedAtRoute("GetTeamSquadFromTeam", new { teamId = teamId, teamSquadId = teamSquadToReturn.Id }, teamSquadToReturn);

        }

        [HttpPut("{teamSquadId}")]
        public ActionResult UpdateTeamSquad(int teamId, int teamSquadId, [FromBody] TeamSquadCreationDto teamSquad)
        {
            var teamSquadFromRepo = teamSquadsRepository.GetTeamSquad(teamId, teamSquadId);

            if (teamSquadFromRepo == null)
            {
                return NotFound();
            }

            mapper.Map(teamSquad, teamSquadFromRepo);

            teamSquadsRepository.UpdateTeamSquad(teamSquadFromRepo);
            teamSquadsRepository.Compleate();

            return NoContent();

        }

        [HttpDelete("{teamSquadId}")]
        public ActionResult DeleteTeamSquad(int teamId, int teamSquadId)
        {
            var teamSquadFromRepo = teamSquadsRepository.GetTeamSquad(teamId, teamSquadId);

            if (teamSquadFromRepo == null)
            {
                return NotFound();
            }

            teamSquadsRepository.DeleteTeamSquad(teamSquadFromRepo);
            teamSquadsRepository.Compleate();

            return NoContent();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkarbKibica.API.Dtos.TeamSquadsDtos;
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

        // GET: api/TeamsSquad
        [HttpGet]
        public IActionResult GetTeamsSquads(int teamId)
        {
            var teamsSquadFromTeamFromRepo = teamSquadsRepository.GetTeamSquads(teamId);

            return Ok(mapper.Map<IEnumerable<TeamSquadDto>>(teamsSquadFromTeamFromRepo));
        }

        // GET: api/TeamsSquad/5
        [HttpGet("{teamSquadId}", Name = "GetTeamSquadFromTeam")]
        public IActionResult Get(int teamId, int teamSquadId)
        {
            var teamSquadFromTeamFromRepo = teamSquadsRepository.GetTeamSquad(teamId, teamSquadId);
            return Ok(mapper.Map<TeamSquadDto>(teamSquadFromTeamFromRepo));
        }

        // POST: api/TeamsSquad
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/TeamsSquad/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

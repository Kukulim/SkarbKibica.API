using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SkarbKibica.API.Dtos;
using SkarbKibica.API.Entities;
using SkarbKibica.API.Services;
using System;
using System.Collections.Generic;

namespace SkarbKibica.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamRepository _teamRepository;
        private readonly IMapper _mapper;

        public TeamsController(ITeamRepository teamRepository, IMapper mapper)
        {
            _teamRepository = teamRepository ??
                throw new ArgumentNullException(nameof(teamRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet()]
        public IActionResult GetTeams()
        {
            var teamsFromRepo = _teamRepository.GetTeams();

            return Ok(_mapper.Map<IEnumerable<TeamDto>>(teamsFromRepo));
        }

        [HttpGet("{id}")]
        public IActionResult GetTeam(int id)
        {
            var teamFromRepo = _teamRepository.GetTeam(id);
            if (teamFromRepo == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<TeamDto>(teamFromRepo));
        }
        [HttpPost]
        public IActionResult CreateTeam(TeamCreationDto teamCreation)
        {
            var teamEntity = _mapper.Map<Team>(teamCreation);
            _teamRepository.AddTeam(teamEntity);
            _teamRepository.Compleate();

            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateTeam(TeamCreationDto teamUpdate, int id)
        {
            var teamFromRepo = _teamRepository.GetTeam(id);
            _mapper.Map(teamUpdate, teamFromRepo);
            
            _teamRepository.UpdateTeam(teamFromRepo);
            _teamRepository.Compleate();

            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTeam(int id)
        {
            _teamRepository.DeleteTeam(id);
            _teamRepository.Compleate();

            return Ok();
        }
    }
}
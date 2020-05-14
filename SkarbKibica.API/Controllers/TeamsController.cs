using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkarbKibica.API.Dtos;
using SkarbKibica.API.Entities;
using SkarbKibica.API.Services;

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
            _mapper = mapper;
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
            if (teamFromRepo== null)
            {
                return NotFound();
            }
            return Ok(teamFromRepo);
        }
    }
}
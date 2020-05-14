using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkarbKibica.API.Services;

namespace SkarbKibica.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamRepository _teamRepository;

        public TeamsController(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository ??
                throw new ArgumentNullException(nameof(teamRepository));
        }

        [HttpGet()]
        public IActionResult GetTeams()
        {
            var teamsFromRepo = _teamRepository.GetTeams();
            return Ok(teamsFromRepo);
        }
        [HttpGet("{id}")]
        public IActionResult GetTeam(int id)
        {
            var teamFromRepo = _teamRepository.GetTeam(id);
            return Ok(teamFromRepo);
        }
    }
}
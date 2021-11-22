using Role_Playing_Game.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Role_Playing_Game.Services.CharacterService;
using System.Threading.Tasks;

namespace Role_Playing_Game.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
       
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;

        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }


        [HttpPost]

        public async Task<IActionResult> AddCharacter(Character newCharacter)
        {
            
            return Ok(await _characterService.AddCharacter(newCharacter));
        }
    }
}
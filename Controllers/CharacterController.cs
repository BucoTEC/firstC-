using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using firstC_.Services.CharacterService;
namespace firstC_.Controllers
{
    [ApiController]
    [Route("api/character")]
    public class CharacterController : ControllerBase
    {

        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Character>>> Get(){
            return Ok(await _characterService.GetAllCharacter());
        }   

         [HttpGet("{id}")]
        public async Task<ActionResult<Character>> GetSingleCharacter(int id){

            return Ok(await _characterService.GetCharacterById(id));

        }    


        [HttpPost]
        public async Task<ActionResult<List<Character>>> AddCharacter(Character newCharacter){

            return Ok(await _characterService.AddCharacter(newCharacter));
        }   
    }
}

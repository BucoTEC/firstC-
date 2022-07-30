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
        public ActionResult<List<Character>> Get(){
            return _characterService.GetAllCharacter();
        }   

         [HttpGet("{id}")]
        public ActionResult<Character> GetSingleCharacter(int id){

            return _characterService.GetCharacterById(id);

        }    


        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter){

            return _characterService.AddCharacter(newCharacter);
        }   
    }
}

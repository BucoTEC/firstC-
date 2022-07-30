using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace firstC_.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {

        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character {Id = 1 ,Name = "Adnan"}
        };


        private static Character character = new Character {Id= 3, Name="Safet"};

        [HttpGet]
        [Route("GetAll")]
        public ActionResult<List<Character>> Get(int id){

            return Ok(characters.FirstOrDefault((character => character.Id == id)));
        }   

         [HttpGet]
        public ActionResult<Character> GetSingleCharacter(){

            return Ok(character);
        }       
    }
}

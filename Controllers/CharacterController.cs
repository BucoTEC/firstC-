using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace firstC_.Controllers
{
    [ApiController]
    [Route("api/character")]
    public class CharacterController : ControllerBase
    {

        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character {Id = 1 ,Name = "Adnan"}
        };


        private static Character character = new Character {Id= 3, Name="Safet"};

        [HttpGet]
        public ActionResult<List<Character>> Get(){

            return Ok(characters);
        }   

         [HttpGet("{id}")]
        public ActionResult<Character> GetSingleCharacter(int id){


            return Ok(characters.FirstOrDefault((character => character.Id == id)));

        }       
    }
}

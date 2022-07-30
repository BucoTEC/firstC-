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
            new Character {Name = "Adnan"}
        };


        private static Character character = new Character {Name="Safet"};

        [HttpGet]
        [Route("GetAll")]
        public ActionResult<List<Character>> Get(){

            return Ok(characters);
        }   

         [HttpGet]
        public ActionResult<Character> GetSingleCharacter(){

            return Ok(character);
        }       
    }
}

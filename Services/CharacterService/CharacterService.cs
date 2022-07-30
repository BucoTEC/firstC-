using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstC_.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {


        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character {Id = 1 ,Name = "Adnan"}
        };
         private static Character character = new Character {Id= 3, Name="Safet"};




        // SERVICES FOR CHARACTER  

        public async Task<ServiceRes<List<Character>>> AddCharacter(Character newCharacter)
        {

            var res = new ServiceRes<List<Character>>();
             characters.Add(newCharacter);
            res.Data = characters;
            return res;
        }

        public async Task<ServiceRes<List<Character>>> GetAllCharacter()
        {
            var res = new ServiceRes<List<Character>>();
            res.Data = characters;
            return res;
        }

        public async Task<ServiceRes<Character>> GetCharacterById(int id)
        {
            var res = new ServiceRes<Character>();
            res.Data = characters.FirstOrDefault(c => c.Id == id);
            return res;
        }
    }
}

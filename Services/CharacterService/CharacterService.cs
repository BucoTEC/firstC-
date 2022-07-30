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

        public async Task<List<Character>> AddCharacter(Character newCharacter)
        {
             characters.Add(newCharacter);

            return characters;
        }

        public async Task<List<Character>> GetAllCharacter()
        {
            return characters;
        }

        public async Task<Character> GetCharacterById(int id)
        {
            return characters.FirstOrDefault(c => c.Id == id);
        }
    }
}

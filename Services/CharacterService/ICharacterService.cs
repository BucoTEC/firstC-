using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstC_.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceRes<List<Character>>> GetAllCharacter();

        Task<ServiceRes<Character>> GetCharacterById(int id);

        Task<ServiceRes<List<Character>>> AddCharacter(Character newCharacter);
    }
}

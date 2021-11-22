using System.Collections.Generic;
using System.Threading.Tasks;
using Role_Playing_Game.Models;

namespace Role_Playing_Game.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<List<Character>> GetAllCharacters();
        Task<Character> GetCharacterById(int id);
        Task<List<Character>> AddCharacter(Character newCharacter);
    }
}
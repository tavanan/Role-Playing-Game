using System.Collections.Generic;
using System.Threading.Tasks;
using Role_Playing_Game.Models;

namespace Role_Playing_Game.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<Character>>> GetAllCharacters();
        Task<ServiceResponse<Character>> GetCharacterById(int id);
        Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);
    }
}
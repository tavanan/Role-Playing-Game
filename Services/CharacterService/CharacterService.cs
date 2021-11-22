using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Role_Playing_Game.Models;

namespace Role_Playing_Game.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {

        private static List<Character> characters = new List<Character> {
            new Character(),
            new Character { Id = 1, Name = "San"}
        };
        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
              var serviceResponse = new ServiceResponse<List<Character>>();
              characters.Add(newCharacter);
              serviceResponse.Data = characters;
              return serviceResponse;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            serviceResponse.Data = characters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            var serviceResponse = new ServiceResponse<Character>();
            serviceResponse.Data = characters.FirstOrDefault(c => c.Id == id);
             return serviceResponse;
        }
    }
}
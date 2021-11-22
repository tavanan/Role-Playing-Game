using System.Collections.Generic;
using System.Linq;
using Role_Playing_Game.Models;

namespace Role_Playing_Game.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {

        private static List<Character> characters = new List<Character> {
            new Character(),
            new Character { Id = 1, Name = "San"}
        };
        public List<Character> AddCharacter(Character newCharacter)
        {
              characters.Add(newCharacter);
              return characters;
        }

        public List<Character> GetAllCharacters()
        {
            return characters;
        }

        public Character GetCharacterById(int id)
        {
             return characters.FirstOrDefault(c => c.Id == id);
        }
    }
}
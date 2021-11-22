using AutoMapper;
using Role_Playing_Game.Dtos.Character;
using Role_Playing_Game.Models;

namespace Role_Playing_Game
{
    public class AutoMapperProfile :Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}
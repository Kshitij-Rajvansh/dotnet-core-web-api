using AutoMapper;
using DotnetWebApi.Dtos.Characters;
using DotnetWebApi.Models;

namespace DotnetWebApi
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}
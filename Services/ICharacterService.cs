using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DotnetWebApi.Models;
using DotnetWebApi.Dtos.Characters;

namespace DotnetWebApi.Services
{
    public interface ICharacterService
    {
         Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
         Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
         Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
         Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);
         Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharater(int id);
    }
}
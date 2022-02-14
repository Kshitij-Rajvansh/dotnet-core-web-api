using System.Threading.Tasks;
using DotnetWebApi.Dtos.Characters;
using DotnetWebApi.Dtos.Weapon;
using DotnetWebApi.Models;

namespace DotnetWebApi.Services
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}
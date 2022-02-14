using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using DotnetWebApi.Services;
using System.Threading.Tasks;
using DotnetWebApi.Dtos.Weapon;
using DotnetWebApi.Models;
using DotnetWebApi.Dtos.Characters;

namespace DotnetWebApi.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class WeaponController : ControllerBase
    {
        private readonly IWeaponService _weaponService;

        public WeaponController(IWeaponService weaponService)
        {
            _weaponService = weaponService;
        }

        [HttpPost]
        public async Task<IActionResult> AddWeapon(AddWeaponDto newWeapon)
        {
            ServiceResponse<GetCharacterDto> serviceResponse = await _weaponService.AddWeapon(newWeapon);

            return Ok(serviceResponse);
        }
    }
}
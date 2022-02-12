using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotnetWebApi.Models;
using DotnetWebApi.Data;
using DotnetWebApi.Dtos.User;

namespace DotnetWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;

        public AuthController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }
        
        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserRegisterDto newUserDto)
        {
            ServiceResponse<int> serviceResponse = await _authRepository.Register
            (
                new User {UserName = newUserDto.UserName},
                newUserDto.Password
            );

            if(!serviceResponse.Success)
            {
                return BadRequest(serviceResponse);
            }

            return Ok(serviceResponse);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserLoginDto userLoginDto)
        {
            ServiceResponse<string> serviceResponse = await _authRepository.Login(userLoginDto.UserName, userLoginDto.Password);

            if(!serviceResponse.Success)
            {
                return BadRequest(serviceResponse);
            }

            return Ok(serviceResponse);
        }
    }
}
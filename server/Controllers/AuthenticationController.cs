﻿using BaseLibrary.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using serverLibrary.Respositories.contract;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AuthenticationController(IuserAccount accountInterface) : ControllerBase
    {
        [HttpPost("register")]

        public async Task<IActionResult> CreateAsync(Register user)
        {
            if (user == null)
            {
                return BadRequest("Model is Empty");
            }
            var result = await accountInterface.CreateAsync(user);
            return Ok(result);


        }
        [HttpPost("Login")]
        public async Task<IActionResult> SignInAsync(Login user)
        {
            if (user == null)
            {
                return BadRequest("Model is Empty");
            }
            var result = await accountInterface.SignInAsync(user);
            return Ok(result);
        }

        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshTokenAsync(RefreshToken token)
        {
            if (token == null) return BadRequest("Model is Empty");
            var result  = await accountInterface.RefreshTokenAsync(token);
            return Ok(result);
        }
    }
}

﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using StoreApp.API.Data;
using StoreApp.API.Data.DTOs.UserDTOs;
using StoreApp.API.Data.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace StoreApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<User> _manager;
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;
        private User? _user;

        private const string _loginProvider = "StoreAPI";
        private const string _refreshToken = "RefreshToken";

        public AuthController(UserManager<User> manager, IConfiguration config, IMapper mapper)
        {
            _manager = manager;
            _config = config;
            _mapper = mapper;
        }

        // POST: api/Auth/register
        [HttpPost]
        [Route("register")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> Register(UserRegisterDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            var result = await _manager.CreateAsync(user, userDto.Password);

            if (result.Succeeded)
            {
                await _manager.AddToRoleAsync(user, "User");
                return Ok(true);
            }
            return BadRequest(false);
        }

        // POST: api/Auth/login
        [HttpPost]
        [Route("login")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<UserTokenDto>> Login([FromBody] UserLoginDto loginDto)
        {
            _user = await _manager.FindByEmailAsync(loginDto.Email);
            bool isValid = await _manager.CheckPasswordAsync(_user, loginDto.Password);

            if (_user == null || !isValid)
            {
                return BadRequest(null);
            }
            var token = await GenerateToken();
            UserTokenDto userReturn = new()
            {
                Token = token,
                Id = _user.Id,
                RefreshToken = await CreateRefreshToken()
            };

            return userReturn;
        }

        [HttpPost]
        [Route("createRefreshToken")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Authorize]
        // Create Refresh Token
        public async Task<string> CreateRefreshToken()
        {
            await _manager.RemoveAuthenticationTokenAsync
                (_user!, _loginProvider, _refreshToken);
            var newRefreshToken = await _manager.GenerateUserTokenAsync
                (_user!, _loginProvider, _refreshToken);
            var result = await _manager.SetAuthenticationTokenAsync
                (_user!, _loginProvider, _refreshToken, newRefreshToken);
            return newRefreshToken;
        }

        // Verify Refresh Token
        [HttpPost]
        [Route("verifyrefreshtoken")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Authorize]
        public async Task<UserTokenDto?> VerifyRefreshToken(UserTokenDto request)
        {

            var jsonSecurityTokeHandler = new JwtSecurityTokenHandler();
            var tokenContent = jsonSecurityTokeHandler.ReadJwtToken(request.Token);
            var userEmail = tokenContent.Claims.ToList()
                .FirstOrDefault(e => e.Type == JwtRegisteredClaimNames.Email)?.Value;

            _user = await _manager.FindByEmailAsync(userEmail);

            if (_user == null)
            {
                return null;
            }

            var isValidRefreshToken = await _manager.VerifyUserTokenAsync
                (_user, _loginProvider, _refreshToken, request.RefreshToken);

            if (isValidRefreshToken)
            {
                var token = await GenerateToken();
                return new UserTokenDto
                {
                    Token = token,
                    Id = _user.Id,
                    RefreshToken = await CreateRefreshToken()
                };
            }
            await _manager.UpdateSecurityStampAsync(_user);
            return null;
        }

        // Generate Token
        private async Task<string> GenerateToken()
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Keys:Key"]!));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var roles = await _manager.GetRolesAsync(_user);
            var roleClaims = roles.Select(x => new Claim(ClaimTypes.Role, x)).ToList();
            var userClaims = await _manager.GetClaimsAsync(_user);

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, _user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, _user.Email),
            }.Union(userClaims).Union(roleClaims);

            var token = new JwtSecurityToken(
                issuer: _config["JwtSettings:Issuer"],
                audience: _config["JwtSettings:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToInt16(_config["JwtSettings:DurationInMinutes"])),
                signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

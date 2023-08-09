using AxiaBackend.Model.DTO;
using AxiaBackend.Model.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace AxiaBackend.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public static User user =new User();
        public readonly IConfiguration _configuration;
        public AuthController(IConfiguration configuration) { 
            _configuration=configuration;
        }
        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(UserDto request)
        {
            CreatePasswordHash(request.userPassword, out byte[] passwordHash, out byte[] passwordSalt);
                 user.userEmail = request.userEmail;
                 user.PasswordSalt = passwordSalt;
                 user.PasswordHash = passwordHash;
            return Ok(user);
        }
        [HttpPost("login")]
        public async Task<ActionResult<User>> Login(UserDto request)
        {
            if(user.userEmail!=request.userEmail)
            {
                return BadRequest("user not found");
            }
            if (!VerifyPasswordHash(request.userPassword,user.PasswordHash,user.PasswordSalt))
            {
                return BadRequest("wrong password");
            }
           string token = CreateToken(user);
            return Ok(token );

        }
        private string CreateToken(User user)
        {
            List<Claim> Claims = new List<Claim>
             {
                new Claim(ClaimTypes.Email,user.userEmail)
              };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var token = new JwtSecurityToken(
                claims: Claims,
                expires: DateTime.Now.AddDays(2),
                signingCredentials: cred);
            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            return jwt;

        }

        private void CreatePasswordHash(string password,out byte[]passwordHAsh,out byte[]passwordSalt)
            {
            using (var hmac=new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHAsh = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }

            }
        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[]passwordSalt)
        {
            using(var hmac=new HMACSHA512(passwordSalt))
            {
                var computedHAsh=hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                   return computedHAsh.SequenceEqual(passwordHash);
            }
        }

        }

    }


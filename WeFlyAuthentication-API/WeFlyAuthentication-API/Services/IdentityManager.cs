using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WeFlyAuthentication_API.Infrastructure;
using WeFlyAuthentication_API.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace WeFlyAuthentication_API.Services
{
    public class IdentityManager : IIdentityManager
    {
        private IdentityDbContext db;
        IConfiguration configuration;

        public IdentityManager(IdentityDbContext _db, IConfiguration _configuration)
        {
            this.db = _db;
            this.configuration = _configuration;
        }

        public async Task<dynamic> AddUserAsync(clsUser user)
        {
            await db.Users.AddAsync(user);
            await db.SaveChangesAsync();
            return new
            {
                user.Id,
                user.FirstName,
                user.LastName,
                user.Email,
                user.Password,
                user.ContactNo
            };
        }

        public string ValidateUser(clsAuthenticate user)
        {
            var result = db.Users.SingleOrDefault(c => c.Email == user.Email && c.Password == user.Password);
            if (result != null)
            {
                string token = GenerateToken(user.Email, user.Password);
                return token;
            }
            return null;
        }

        public string GenerateToken(string email, string password)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,email),
                new Claim(JwtRegisteredClaimNames.Email,email),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
            };

            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "Token");

            if (email == "siddheshrasam89@gmail.com")
            {
                claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, "Admin"));
            }

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration.GetValue<string>("Jwt:Secret")));
            var credential = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256); ;
            var token = new JwtSecurityToken(
                    issuer: configuration.GetValue<string>("Jwt:Issuer"),
                    audience: configuration.GetValue<string>("Jwt:Audience"),
                    claims: claimsIdentity.Claims,
                    expires: DateTime.Now.AddMinutes(30),
                    signingCredentials: credential
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

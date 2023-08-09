using AxiaBackend.Interfaces;
using AxiaBackend.Model.Entities;
using System.Security.Cryptography;

namespace AxiaBackend.Services
{
    public class RefreshTokenGeneratorService : IRefreshTokenGenerator
    {
        public AppDataContext _context { get; set; }
        public RefreshTokenGeneratorService(AppDataContext prAppDataContext)
        {
            _context = prAppDataContext;
        }

        public string GenerateToken(string username)
        {
            var randomnumber = new byte[32];
            using (var randomnumbergenerator = RandomNumberGenerator.Create())
            {
                randomnumbergenerator.GetBytes(randomnumber);
                string RefreshToken = Convert.ToBase64String(randomnumber);


                TRefreshToken tblRefreshtoken = new TRefreshToken()
                {
                    UserId = username,
                    TokenId = new Random().Next().ToString(),
                    RefreshToken = RefreshToken,
                    IsActive = true
                };

                return RefreshToken;
            }
        }

    }
}

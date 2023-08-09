namespace AxiaBackend.Interfaces
{
    public interface IRefreshTokenGenerator
    {
  
            string GenerateToken(string username);
    }
}

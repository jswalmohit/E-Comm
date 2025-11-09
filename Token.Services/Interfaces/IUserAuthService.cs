namespace Authentication.Services.Interfaces
{
    public interface IUserAuthService
    {
        Task<string> GetUserToken(string username, string password);
    }
}

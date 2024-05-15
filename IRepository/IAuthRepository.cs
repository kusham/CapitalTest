using CapitalTest.Models;

namespace CapitalTest.IRepository
{
    public interface IAuthRepository
    {
        Task<Users> RegisterUser(Users user);
        Task<Users?> GetUserByEmail(string email);
    }
}

using GucciFestival.Shared.Models;

namespace GucciFestival.Server.Services
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
    }
}

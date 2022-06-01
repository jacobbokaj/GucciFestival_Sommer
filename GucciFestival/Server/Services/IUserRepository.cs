using GucciFestival.Shared.Models;

namespace GucciFestival.Server.Services
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();

        void AddUser(User user);

        bool UpdateUser(User shift);
        bool DeleteUser(int user_id);
    }
}

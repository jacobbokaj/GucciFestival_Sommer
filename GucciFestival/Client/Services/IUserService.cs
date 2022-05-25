using GucciFestival.Shared.Models;

namespace GucciFestival.Client.Services
{
    public interface IUserService
    {
        public Task<User[]?> GetAllUsers();

        Task<int> AddUser(User user);
    }
}

using GucciFestival.Shared.Models;

namespace GucciFestival.Client.Services
{
    public interface IUserCompetence
    {
        public Task<UserCompetence[]?> GetAllUsers();

        Task<int> AddUser(UserCompetence userCompetence);
    }
}

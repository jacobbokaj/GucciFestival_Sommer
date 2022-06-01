using GucciFestival.Shared.Models;

namespace GucciFestival.Client.Services
{
    public interface IUserCompetenceService
    {
        public Task<UserCompetence[]?> GetAllUserCompetence();

        Task<int> AddUserCompetence(UserCompetence userCompetence);
        Task<int> UpdateUserCompetence(UserCompetence userCompetence);
        public Task<int> DeleteUserCompetence(UserCompetence userCompetence);
    }
}

using GucciFestival.Client.Services;
using GucciFestival.Shared.Models;

namespace GucciFestival.Client.Models
{
    public class UserCompetenceService : IUserCompetence
    {
        private readonly HttpClient httpClient;
        public UserCompetenceService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task<int> AddUser(UserCompetence userCompetence)
        {
            throw new NotImplementedException();
        }

        public Task<UserCompetence[]?> GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}

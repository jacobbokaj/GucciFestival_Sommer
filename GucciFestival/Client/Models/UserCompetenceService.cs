using System.Net.Http.Json;
using GucciFestival.Client.Services;
using GucciFestival.Shared.Models;

namespace GucciFestival.Client.Models
{
    public class UserCompetenceService : IUserCompetenceService
    {
        private readonly HttpClient httpClient;
        public UserCompetenceService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task<int> AddUserCompetence(UserCompetence userCompetence)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteUserCompetence(UserCompetence userCompetence)
        {
            throw new NotImplementedException();
        }

        public Task<UserCompetence[]?> GetAllUserCompetence()
        {
            Console.WriteLine("In await");
            var result = httpClient.GetFromJsonAsync<UserCompetence[]>("api/userCompetenceapi");
            return result;
        }

            public Task<int> UpdateUserCompetence(UserCompetence userCompetence)
        {
            throw new NotImplementedException();
        }
    }
}

using GucciFestival.Client.Services;
using GucciFestival.Shared.Models;
using System.Net.Http.Json;


namespace GucciFestival.Client.Models
{
    public class VolunteerService :IVolunteerService
    {
        private readonly HttpClient httpClient;

        public VolunteerService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task<Volunteer[]?> GetAllVolunteers()
        {
            var result = httpClient.GetFromJsonAsync<Volunteer[]>("api/volunteerapi");
            return result;
        }
        public async Task<int> AddVolunteer(Volunteer volunteer)
        {
            var result = await httpClient.PostAsJsonAsync<Volunteer>("api/volunteerapi", volunteer);
            return (int)result.StatusCode;
        }


    }
}

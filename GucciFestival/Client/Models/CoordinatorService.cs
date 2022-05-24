using GucciFestival.Client.Services;
using GucciFestival.Shared.Models;
using System.Net.Http.Json;

namespace GucciFestival.Client.Models
{
    public class CoordinatorService : ICoordinatorService
    {
            private readonly HttpClient httpClient;

            public CoordinatorService(HttpClient httpClient)
            {
                this.httpClient = httpClient;
            }

            public Task<Coordinator[]?> GetAllCoordinators()
            {
                var result = httpClient.GetFromJsonAsync<Coordinator[]>("api/coordinatorapi");
                return result;
            }
            public async Task<int> AddCoordinator(Coordinator coordinator)
            {
                var result = await httpClient.PostAsJsonAsync<Coordinator>("api/coordinatorapi", coordinator);
                return (int)result.StatusCode;

            }

        
    }
}

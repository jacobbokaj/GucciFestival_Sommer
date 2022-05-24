using GucciFestival.Shared.Models;
using GucciFestival.Client.Services;
using System.Net.Http.Json;

namespace GucciFestival.Client.Models
{
    public class AreaService : IAreaService


    {
        private readonly HttpClient httpClient;

        public AreaService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        //Her henter vi data fra vores api og får det som en JSON fil
        //Vi bruger Async til at sørge for alt dataen er hentet før det loader
        public async Task<Area[]?> GetAllAreas()
        {
            var result = await httpClient.GetFromJsonAsync<Area[]>("api/areaapi");

            return result;
        }
        public async Task<int> AddCoordinator(Area area)
        {
            var result = await httpClient.PostAsJsonAsync<Area>("api/areaapi", area);
            return (int)result.StatusCode;

        }
    }
}

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
        public async Task<Area[]?> GetAllAreas()
        {
            var result = await httpClient.GetFromJsonAsync<Area[]>("api/areapi");

            return result;
        }

    }
}

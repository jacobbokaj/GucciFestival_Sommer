using GucciFestival.Client.Services;
using GucciFestival.Shared.Models;
using System.Net.Http.Json;

namespace GucciFestival.Client.Models
{
    public class ShiftService : IShiftService
    {
        private readonly HttpClient httpClient;

        public ShiftService(HttpClient httpClient)
        {
           this.httpClient = httpClient;
        }
        public async Task<Shift[]?> GetAllShifts()
        {
            var result = await httpClient.GetFromJsonAsync<Shift[]>("api/shitapi");
            return result;
        }
    }
}

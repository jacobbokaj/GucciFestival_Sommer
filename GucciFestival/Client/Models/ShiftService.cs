using GucciFestival.Client.Services;
using GucciFestival.Shared.Models;
using System.Net.Http.Json;
using GucciFestival.Shared.Models;

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
            var result = await httpClient.GetFromJsonAsync<Shift[]>("api/shiftapi");
          
            return result;
        }
        public async Task<int> AddShift(Shift shift)
        {
            var result = await httpClient.PostAsJsonAsync<Shift>("api/shiftapi", shift);
            return (int)result.StatusCode;
        }
    }
}


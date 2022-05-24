using GucciFestival.Client.Services;
using GucciFestival.Shared.Models;
using System.Net.Http.Json;
using GucciFestival.Shared.Models;

namespace GucciFestival.Client.Models
{
    public class ShiftService : IShiftService
    {
        private readonly HttpClient httpClient;

        /// <summary>
        /// Paramenteren kommer fra klassen "program.cs" i "GucciFestival.Client"
        /// Hvor den "addHttpClient" Med kommunikationen imellem IShiftService og denne klasse.
        /// </summary>
        /// <param name="httpClient"></param>
        public ShiftService(HttpClient httpClient)
        {
           this.httpClient = httpClient;
        }
        
        /// <summary>
        /// Har kommunikation med "shiftapi", som er "ShiftController" i "GucciFestival.Server".
        /// Siden det er httpclient, bruger den [HttpGet] for at få dataen.
        /// </summary>
        /// <returns></returns>
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


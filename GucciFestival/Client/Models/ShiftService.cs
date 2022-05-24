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
        /// Det kommer som Json fil, derfor skal "GetFromJsonAsync" bruges for at lave det til data der kan ligges i en klasse.
        /// Async Venter til at alt dataen er med, før den melder det er udført. Async køre i et andet sted for at hjemmesiden ikke vil lag til det er hentet.
        /// Hvilket gør at det kan være svært nogle gange at vide, hvornår den er færdig.
        /// </summary>
        /// <returns></returns>
        public async Task<Shift[]?> GetAllShifts()
        {
            var result = await httpClient.GetFromJsonAsync<Shift[]>("api/shiftapi");
          
            return result;
        }
    }
}

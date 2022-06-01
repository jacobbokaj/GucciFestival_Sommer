using GucciFestival.Client.Services;
using GucciFestival.Shared.Models;
using System.Net.Http.Json;

namespace GucciFestival.Client.Models
{
    public class UserService : IUserService
    {
        private readonly HttpClient httpClient;
        /// <summary>
        /// Paramenteren kommer fra klassen "program.cs" i "GucciFestival.Client"
        /// Hvor den "addHttpClient" Med kommunikationen imellem IShiftService og denne klasse.
        /// </summary>
        /// <param name="httpClient"></param>
        public UserService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        /// <summary>
        /// Har kommunikation med "shiftapi", som er "ShiftController" i "GucciFestival.Server".
        /// Siden det er httpclient, bruger den [HttpGet] for at få dataen.
        /// Det kommer som Json fil, derfor skal "GetFromJsonAsync" bruges for at lave det til data der kan ligges i en klasse.
        /// Async Venter til at alt dataen er med, før den melder det er udført. Async køre i et andet sted for at hjemmesiden ikke vil lag til det er færdig.
        /// Hvilket gør at det kan være at svært vide, hvornår den er færdig.
        /// </summary>
        /// <returns></returns>
        public Task<User[]?> GetAllUsers()
        {
            Console.WriteLine("In await");
            var result = httpClient.GetFromJsonAsync<User[]>("api/userapi");
           
            
            return result;
        }
        public async Task<int> AddUser(User user)
        {
            var result = await httpClient.PostAsJsonAsync<User>("api/userapi", user);
            return (int)result.StatusCode;
        }

        public async Task<int> UpdateUser(User user)
        {
            var result = await httpClient.PutAsJsonAsync<User>("api/userapi", user);
            return (int)result.StatusCode;
        }

        public async Task<int> DeleteUser(User user)
        {
            var response = await httpClient.DeleteAsync("api/userapi/" + user.User_id);
            var responseStatusCode = response.StatusCode;
            return (int)responseStatusCode;
        }
    }
}

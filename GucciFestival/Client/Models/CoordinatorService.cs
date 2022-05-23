using GucciFestival.Client.Services;
using System.Net.Http.Json;

namespace GucciFestival.Client.Models
{
    public class CoordinatorService : ICoordinatorService
    {

        {
            private readonly HttpClient httpClient;

            public CoordinatorService(HttpClient httpClient)
            {
                this.httpClient = httpClient;
            }

            public Task<UserService[]?> GetAllBookings()
            {
                var result = httpClient.GetFromJsonAsync<UserService[]>("api/bookingapi");
                return result;
            }
            public async Task<int> AddBooking(Booking booking)
            {
                var result = await httpClient.PostAsJsonAsync<Booking>("api/bookingapi", booking);
                return (int)result.StatusCode;
            }

        }
    }
}

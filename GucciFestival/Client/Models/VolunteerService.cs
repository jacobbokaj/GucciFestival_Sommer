namespace GucciFestival.Client.Models
{
    public class VolunteerService
    {
        private readonly HttpClient httpClient;
        public VolunteerService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        
    }
}

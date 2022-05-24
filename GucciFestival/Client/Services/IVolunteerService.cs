using GucciFestival.Shared.Models;

namespace GucciFestival.Client.Services
{
    public interface IVolunteerService
    {
        Task<Volunteer[]?> GetAllVolunteers();
        Task<int> AddVolunteer(Volunteer volunteer);
    }
}

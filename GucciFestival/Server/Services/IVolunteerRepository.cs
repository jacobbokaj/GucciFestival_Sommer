using GucciFestival.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace GucciFestival.Server.Services
{
    public interface IVolunteerRepository
    {
        List<Volunteer> GetAllVolunteers();
        List<Volunteer> AddVolunteer();
    }
}

using GucciFestival.Shared.Models;
namespace GucciFestival.Server.Services
{
    public interface IUserCompetenceRepository
    {

        List<UserCompetence> GetAllUsers();
    }
}

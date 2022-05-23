using GucciFestival.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace GucciFestival.Server.Services
{
    public interface ICoordinatorRepository
    {
        List<Coordinator> GetAllCoordinators();
        List<Coordinator> AddCoordinator();
    }
}

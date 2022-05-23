using GucciFestival.Shared.Models;

namespace GucciFestival.Client.Services
{
    public interface ICoordinatorService
    {
        Task<Coordinator[]?> GetAllCoordinators();
        Task<int> AddCoordinator(Coordinator coordinator);
    }

}

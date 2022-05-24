using GucciFestival.Server.Services;
using GucciFestival.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace GucciFestival.Server.Models
{
    public class CoordinatorRepository : ICoordinatorRepository
        {
            public List<Coordinator> GetAllCoordinators()
            {
                throw new NotImplementedException();
            }

        public List<Coordinator> AddCoordinator()
        {
            throw new NotImplementedException();
        }
    }
}

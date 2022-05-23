using GucciFestival.Server.Models;
using GucciFestival.Server.Services;
using GucciFestival.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace GucciFestival.Server.Controllers
{
    public class CoordinatorController : ControllerBase
    {

        private readonly ICoordinatorRepository Repository = new CoordinatorRepository();

        public CoordinatorController(ICoordinatorRepository coordinatorRepository)
        {
            if (coordinatorRepository != null)
            {
                Repository = coordinatorRepository;
            }
        }

        [HttpGet]
        public IEnumerable<Coordinator> GetAllCoordinators()
        {
            return Repository.GetAllCoordinators();
        }
        [HttpGet]
        public IEnumerable<Coordinator> AddCoordinator()
        {
            return Repository.AddCoordinator();
        }

    }
}



    
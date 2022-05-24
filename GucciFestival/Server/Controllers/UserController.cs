using GucciFestival.Server.Models;
using GucciFestival.Server.Services;
using GucciFestival.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace GucciFestival.Server.Controllers
{
    [ApiController]
    [Route("api/userapi")]
    public class UserController
    {
        private readonly IUserRepository repository = new UserRepository();
        public UserController(IUserRepository repository)
        {
            if (repository != null)
            {
                this.repository = repository;
            }
        }

        [HttpGet]
        public IEnumerable<User> GetAllUsers()
        {
            return repository.GetAllUsers();
        }

        [HttpPost]
        public void AddUser(User user)
        {
            repository.AddUser(user);
        }
    }
}

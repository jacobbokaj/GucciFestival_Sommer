using GucciFestival.Server.Models;
using GucciFestival.Server.Services;
using GucciFestival.Shared.Competences;
using GucciFestival.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace GucciFestival.Server.Controllers
{
    [ApiController]
    [Route("api/userapi")]
    public class UserController
    {
        private readonly IUserRepository repository = null;
        public UserController(IUserRepository repository)
        {
            if (repository != null)
            {
                //Henter classen userRepository for at få adgang til alle dapper metoderne, som kalder på pgadmin/sql.
                this.repository = repository;
            }
        }

        [HttpGet]
        public IEnumerable<User> GetAllUsers()
        {
            foreach (var item in repository.GetAllUsers())
            {
                Console.WriteLine("Data  birthday: " + item.Birthday);
            }
            return repository.GetAllUsers();
        }

        [HttpPost]
        public void AddUser(User user)
        {

            repository.AddUser(user);
        }
        [HttpPut]
        public void UpdateUser(User user)
        {
            Console.WriteLine("Update HTTPPUT");
            repository.UpdateUser(user);
        }

        [HttpDelete("{id:int}")]
        public void DeleteUser(int id)
        {
            repository.DeleteUser(id);
        }
    }
}

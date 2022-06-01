using GucciFestival.Server.Models;
using GucciFestival.Server.Services;
using GucciFestival.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace GucciFestival.Server.Controllers
{

    [ApiController]
    [Route("api/userCompetenceapi")]
    public class UserCompetenceController
    {

     /*   private readonly IUserCompetenceRepository repository = new UserCompetenceRepository();
        public UserCompetenceController(IUserCompetenceRepository repository)
        {
            if (repository != null)
            {
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
     */
    }
}

using GucciFestival.Server.Services;
using GucciFestival.Shared.Models;

namespace GucciFestival.Server.Models
{
    public class UserRepository : IUserRepository
    {
        PgAdminDBContext db = new PgAdminDBContext();

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            users.Add(new User());

            return users;
        }
        public void AddUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}

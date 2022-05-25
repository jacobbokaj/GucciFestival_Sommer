using GucciFestival.Server.Services;
using GucciFestival.Shared.Models;

namespace GucciFestival.Server.Models
{
    public class UserRepository : IUserRepository
    {
        PgAdminDBContext db = new PgAdminDBContext();

        public List<User> GetAllUsers()
        {
            //List<User> users = new List<User>();
            //users.Add(new User());

            return db.Users;
        }
        public void AddUser(User user)
        {
            Console.WriteLine("Add user in server user");
            string sql = "CALL creat_user('Kim','1995-05-10','Kimmi@gmail.gg','2321','hewaj','2','6','1','gfwww')";
            db.Add(sql);
        }
    }
}

using GucciFestival.Server.Services;
using GucciFestival.Shared.Models;

namespace GucciFestival.Server.Models
{
    public class UserRepository : IUserRepository
    {
        PgAdminDBContext db = new PgAdminDBContext();

        public List<User> GetAllUsers()
        {
            db.GetAllUsers("SELECT name,birthday, email, phone, password, user_id, type_id, type  FROM \"User\";");
            //List<User> users = new List<User>();
            //users.Add(new User());
            //users[0].Name = "hihi xd";
            Console.WriteLine(db.Users[0].Password);
            return db.Users;
        }
        public void AddUser(User user)
        {
            Console.WriteLine("Add user in server user");
            db.CUD("call create_user5('Kennth','05-09-1991', 'Kennethgmai.com','12345678','password', '{1,2}')");
           // string sql = $"CALL creat_user('{user.Name}','{user.Birthday}','{user.Email}','{user.Phone}','{user.Password}','{user.User_id}','{user.Type_id}','{user.Type}')";
           // db.CUD(sql);
        }
    }
}

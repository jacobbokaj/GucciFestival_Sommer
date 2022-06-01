using GucciFestival.Server.Services;
using GucciFestival.Shared.Competences;
using GucciFestival.Shared.Models;

namespace GucciFestival.Server.Models
{
    public class UserRepository : IUserRepository
    {
        PgAdminDBContext db = new PgAdminDBContext();

        public List<User> GetAllUsers()
        {
            db.GetAllUsers("SELECT name,birthday, email, phone, password, user_id, type_id, type  FROM \"User\";");
            db.GetAllUserCompetences("SELECT \"User_user_id\", competence_competence_id FROM \"User_competence\"");
            for     (int i = 0; i < db.Users.Count; i++)
            {
                for (int j = 0; j < db.UserCompetences.Count; j++)
                    if(db.Users[i].User_id == db.UserCompetences[j].User_User_Id)
                    {
                       db.Users[i].Competences.Add((Competences)(db.UserCompetences[j].Competence_Competence_Id - 1));
                   //     Console.WriteLine($"User Competence {db.Users[i].Name} Enum: {db.Users[i].Competences[0]} ");
                    }
                Console.WriteLine($" user competence count: {db.Users[i].Competences.Count}");
            }
            //List<User> users = new List<User>();
            //users.Add(new User());
            //users[0].Name = "hihi xd";
           // Console.WriteLine(db.Users[0].Password);
            return db.Users;
        }
        public void AddUser(User user)
        {
            Console.WriteLine("Add user in server user");
            db.CUD("call create_user5('Kennth','05-09-1991', 'Kennethgmai.com','12345678','password', '{1,2}')");
           // string sql = $"CALL creat_user('{user.Name}','{user.Birthday}','{user.Email}','{user.Phone}','{user.Password}','{user.User_id}','{user.Type_id}','{user.Type}')";
           // db.CUD(sql);
        }

        public bool UpdateUser(User user)
        {

            List<User> users = new List<User>();
            users = GetAllUsers();
            foreach (var item in users)
            {
               
            }
            string sql = $"UPDATE \"User\" " +
                $"SET name= '{user.Name}', birthday = '{user.Birthday.ToString("MM-dd-yyyy")}', email = '{user.Email}', phone = {user.Phone}," +
                $" password = '{user.Password}', User_id = {user.User_id} WHERE User_id = {user.User_id}";
            
            Console.WriteLine("USER UPDATE SQL: "+ sql);
            db.CUD(sql);
            return true;
        }

        public bool DeleteUser(int user_id)
        {
            string sql = $"DELETE FROM \"User\" WHERE User_id = {user_id}";
            Console.WriteLine("DELETE USER implement needed");
            db.CUD(sql);
            return true;
        }
    }
}

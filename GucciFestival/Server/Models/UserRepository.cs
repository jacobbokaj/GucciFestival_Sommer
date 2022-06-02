using GucciFestival.Server.Services;
using GucciFestival.Shared.Competences;
using GucciFestival.Shared.Models;

namespace GucciFestival.Server.Models
{
    public class UserRepository : IUserRepository
    {
        PgAdminDBContext db = null;

        public UserRepository(IConfiguration Iconfig )
        {
            db = new PgAdminDBContext( Iconfig );
        }
        public List<User> GetAllUsers()
        {
            db.GetAllUsers("SELECT name,birthday, email, phone, password, user_id, type_id, type  FROM \"User\";");
            db.GetAllUserCompetences("SELECT \"User_user_id\", competence_competence_id FROM \"User_competence\"");
            for     (int i = 0; i < db.Users.Count; i++)
            {
                for (int j = 0; j < db.UserCompetences.Count; j++)
                    if(db.Users[i].User_id == db.UserCompetences[j].User_User_Id)
                    {
                       db.Users[i].Competences_Id.Add(db.UserCompetences[j].Competence_Competence_Id - 1);
                   //     Console.WriteLine($"User Competence {db.Users[i].Name} Enum: {db.Users[i].Competences[0]} ");
                    }
                Console.WriteLine($" user {db.Users[i].Name} competence count: {db.Users[i].Competences_Id.Count}");
            }
            //List<User> users = new List<User>();
            //users.Add(new User());
            //users[0].Name = "hihi xd";
           // Console.WriteLine(db.Users[0].Password);
            return db.Users;
        }
        public void AddUser(User user)
        {
            string sqlArray = "{";

            for (int i = 0; i < user.Competences_Id.Count; i++)
            {
                sqlArray += $"{user.Competences_Id[i]}" + (i + 1 < user.Competences_Id.Count ? "," : "");
            }
            sqlArray += "}";



            string sql = $"call create_user5('{user.Name}','{user.Birthday.ToString("MM-dd-yyyy")}', '{user.Email}','{user.Phone}','{user.Password}', '{sqlArray}')";


            Console.WriteLine("Add user sql: " + sql);
            db.CUD(sql);;
        }

        public bool UpdateUser(User user)
        {
            //string sql = $"UPDATE \"User\" " +
            //    $"SET name= '{user.Name}', birthday = '{user.Birthday.ToString("MM-dd-yyyy")}', email = '{user.Email}', phone = {user.Phone}," +
            //    $" password = '{user.Password}', User_id = {user.User_id} WHERE User_id = {user.User_id}";

            string sqlArray = "{";

            for (int i = 0; i < user.Competences_Id.Count; i++)
            {
                sqlArray += $"{user.Competences_Id[i]}" + (i + 1 < user.Competences_Id.Count ? "," : "");
            }
            sqlArray += "}";




            string sql = $"call update_user1('{user.Name}','{user.Birthday.ToString("MM-dd-yyyy")}','{user.Email}',{user.Phone}," +
                $"'{user.Password}',{user.User_id},'{sqlArray}')";
            Console.WriteLine("USER UPDATE SQL: "+ sql);
            db.CUD(sql);
            return true;
        }

        public bool DeleteUser(int user_id)
        {
            string sql = $"call delete_user1({user_id})";
            db.CUD(sql);
            return true;
        }
    }
}

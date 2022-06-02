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
                    //Den siger +1, fordi C#/ i denne applikation starter alt fra 0, men pgadmin/sql starter alt fra 1 i tables.
                    if (db.Users[i].User_id == db.UserCompetences[j].User_User_Id)
                    {

                       db.Users[i].Competences_Id.Add(db.UserCompetences[j].Competence_Competence_Id - 1);
                    }
            }
            return db.Users;
        }
        public void AddUser(User user)
        {
            //En list kan ikke direkte sættes ind i sql statement, derfor bruges denne forloop for at "oversætte det"
            //Denne bliver til f.eks. hvis competence 2,3,5 i en list, bliver den lavet til {2,3,5}
            string sqlArray = "{";
            for (int i = 0; i < user.Competences_Id.Count; i++)
            {
                sqlArray += $"{user.Competences_Id[i]}" + (i + 1 < user.Competences_Id.Count ? "," : "");
            }
            sqlArray += "}";



            string sql = $"call create_user5('{user.Name}','{user.Birthday.ToString("MM-dd-yyyy")}', '{user.Email}','{user.Phone}','{user.Password}', '{sqlArray}')";


            db.CUD(sql);
        }

        public bool UpdateUser(User user)
        {

            //En list kan ikke direkte sættes ind i sql statement, derfor bruges denne forloop for at "oversætte det"
            //Denne bliver til f.eks. hvis competence 2,3,5 i en list, bliver den lavet til {2,3,5}
            string sqlArray = "{";
            for (int i = 0; i < user.Competences_Id.Count; i++)
            {
                sqlArray += $"{user.Competences_Id[i]}" + (i + 1 < user.Competences_Id.Count ? "," : "");
            }
            sqlArray += "}";




            string sql = $"call update_user1('{user.Name}','{user.Birthday.ToString("MM-dd-yyyy")}','{user.Email}',{user.Phone}," +
                $"'{user.Password}',{user.User_id},'{sqlArray}')";
            Console.WriteLine(sql);
            db.CUD(sql);
            //Metoden bool er med, fordi det gør applikationen mere fleksibel for videre udvikling
            return true;
        }

        public bool DeleteUser(int user_id)
        {
            string sql = $"call delete_user1({user_id})";
            db.CUD(sql);
            //Metoden bool er med, fordi det gør applikationen mere fleksibel for videre udvikling
            return true;
        }
    }
}

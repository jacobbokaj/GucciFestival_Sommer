using Dapper;
using GucciFestival.Shared.Models;
using Npgsql;

namespace GucciFestival.Server.Models
{
    public class PgAdminDBContext
    {
        public List<User> Users { get; private set; } = new List<User>();
        public List<Shift> Shifts { get; private set; } = new List<Shift>();
        public List<Area> Areas { get; private set; } = new List<Area>();

    
        public PgAdminDBContext()
        {
           //// var constring = $"UserID=postgres;Password=postgres;Host=localhost;Port=5432;Database=practice";
           // var constring = "UserID=Anders95;Password=Hejhej1234;Host=guccifestival.postgres.database.azure.com;Port=5432;Database=gucci_festival_projekt";
           //// var constring = $"postgres://Anders95:Hejhej1234@guccifestival.postgres.database.azure.com/postgres?sslmode=require";
           // var sql = "SELECT name,birthday, email, tlf, password, competence_id, user_id, type_id, type  FROM \"User\";";
           //// var sql = "SELECT name FROM \"User\";";
           // // var sql = "SELECT first_name, password FROM user_v2;";
           // Console.WriteLine("query SQL: " + sql);
           // using (var connection = new NpgsqlConnection(constring))
           // {
           //     var test_sqlss = connection.Query<User> (sql);
           //     foreach (var tt in test_sqlss)
           //     {
           //       Console.WriteLine (tt.Birthday);
           //         Console.WriteLine(tt.Name);

           //     }

           // }
        }
        public void Add(string sql)
        {
            Console.WriteLine("Add :D");
            var constring = "UserID=Anders95;Password=Hejhej1234;Host=guccifestival.postgres.database.azure.com;Port=5432;Database=gucci_festival_projekt";
            using (var connection = new NpgsqlConnection(constring))
            {
                var test_sqlss = connection.Execute(sql);
                //foreach (var tt in test_sqlss)
                //{
                //    Console.WriteLine(tt.Birthday);
                //    Console.WriteLine(tt.Name);

                //}
            }
        }
    }
}

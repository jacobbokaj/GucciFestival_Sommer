using Dapper;
using GucciFestival.Shared.Models;
using Npgsql;

namespace GucciFestival.Server.Models
{
    public class PgAdminDBContext
    {
        public List<User> Users { get; private set; }
        public List<Shift> Shifts { get; private set; } = new List<Shift>();
        public List<Area> Areas { get; private set; } = new List<Area>();

        public List<Volunteer> Volunteers { get; private set; } = new List<Volunteer>();
        public PgAdminDBContext()
        {
                Console.WriteLine("query SQL");

            var constring = "UserID=Anders95;Password=Hejhej1234;Host=guccifestival.postgres.database.azure.com/postgres?sslmode=require;Port=5432;Database=gucci_festival_sommer";
           // var constring = $"postgres://Anders95:Hejhej1234@guccifestival.postgres.database.azure.com/postgres?sslmode=require";
            var sql = "SELECT navn, område_id, bruger_id, festival_id FROM festival; ";
            using (var connection = new NpgsqlConnection(constring))
            {
                var test_sqlss = connection.Query<Shift>(sql);
                foreach (var tt in test_sqlss)
                {
                    Console.WriteLine($"{tt.Id}");

                }

            }
        }
    }
}

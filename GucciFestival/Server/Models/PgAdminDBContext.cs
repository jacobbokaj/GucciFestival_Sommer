using Dapper;
using GucciFestival.Shared.Models;
using Npgsql;

namespace GucciFestival.Server.Models
{
    public class PgAdminDBContext
    {
        public List<Shift> Shifts { get; private set; }

        public PgAdminDBContext()
        {
            var constring = $"postgres://Anders95:Hejhej1234@guccifestival.postgres.database.azure.com/postgres?sslmode=require";
            var sql = "SELECT firstname, lastname FROM test_sql";
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

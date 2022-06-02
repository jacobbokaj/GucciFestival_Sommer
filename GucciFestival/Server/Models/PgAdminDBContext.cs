using Dapper;
using GucciFestival.Shared.Models;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace GucciFestival.Server.Models
{
    public class PgAdminDBContext
    {
        //private string constring = "UserID=Anders95;Password=Hejhej1234;Host=guccifestival.postgres.database.azure.com;Port=5432;Database=gucci_festival_sommer";
        private string constring = "";
        public List<User> Users { get; private set; } = new List<User>();
        public List<Shift> Shifts { get; private set; } = new List<Shift>();

        public List<UserCompetence> UserCompetences { get; private set; } = new List<UserCompetence> ();

        
        public PgAdminDBContext(IConfiguration config)
        {
            constring = config.GetConnectionString("myDB");
        }
        public void GetAllUsers(string sql)
        {
            using (var connection = new NpgsqlConnection(constring))
            {
                Users = connection.Query<User>(sql).ToList();
               
            }
        }
        public void GetAllUserCompetences(string sql)
        {
            using (var connection = new NpgsqlConnection(constring))
            {
                UserCompetences = connection.Query<UserCompetence>(sql).ToList();
            }
        }
        public void GetAllShifts(string sql){
            using (var connection = new NpgsqlConnection(constring))
            {
                Shifts = connection.Query<Shift>(sql).ToList();
                
            }
        } 
        /// <summary>
        /// Create, update, delete.
        /// </summary>
        public void CUD(string sql )
        {
            using (var connection = new NpgsqlConnection(constring))
            {
                connection.Execute(sql);
            }
        }
    }
}

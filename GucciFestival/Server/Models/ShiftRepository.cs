using GucciFestival.Server.Services;
using GucciFestival.Shared.Models;

namespace GucciFestival.Server.Models
{
    public class ShiftRepository : IShiftRepository
    {
        private PgAdminDBContext db = null;
        
        public ShiftRepository(IConfiguration iconfig)
        {
            db = new PgAdminDBContext(iconfig);
        }
        public List<Shift> GetAllShifts()
        {
            db.GetAllShifts("SELECT name, start_time, end_time, competence_id, shift_id, shift_taken_id FROM shift");

            foreach (var item in db.Shifts)
            {
                //Den siger +1, fordi C#/ i denne applikation starter alt fra 0, men pgadmin/sql starter alt fra 1 i tables.
                item.Competence_Id = item.Competence_Id - 1;
            }
            return db.Shifts;
        }
        public void AddShift(Shift shift)
        {
            var sql = $"INSERT INTO shift VALUES('{shift.Name}',{shift.Competence_Id}, {shift.Shift_Id}," +
              $"{shift.Shift_Taken_Id},'{shift.Start_Time.ToString("MM-dd-yyyy")}','{shift.End_Time.ToString("MM-dd-yyyy")}')";
            db.CUD(sql);
        }

        public bool DeleteShift(int id)
        {
            string sql = $"DELETE FROM shift WHERE shift_id = {id}";
            db.CUD(sql);
            //Oplysningerne bliver checket i coordinator og bliver checket med editcontext, derfor er den altid true.
            //Metoden bool er med, fordi det gør applikationen mere fleksibel for videre udvikling
            return true;
        }

        public bool UpdateShift(Shift shift)
        {
             string sql = $"UPDATE shift SET name = '{shift.Name}', competence_id = {shift.Competence_Id}, shift_taken_id = {shift.Shift_Taken_Id}," +
                $"start_time = '{shift.Start_Time.ToString("MM-dd-yyyy")}', end_time = '{shift.End_Time.ToString("MM-dd-yyyy")}' WHERE shift_id = {shift.Shift_Id}";
              db.CUD(sql);
            //Vil altid return true, fordi oplysningerne bliver checket i coordinator page, da, f.eks. navnet bliver ændret bliver det også ændret i databasen.
            //Metoden bool er med, fordi det gør applikationen mere fleksibel for videre udvikling
            return true;
        }
    }
}

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
            // List<Shift> shifts = new List<Shift>();
            //shifts.Add(new Shift());
            //shifts.Add(new Shift());
            //shifts[0].Name = "Pandekager";
            //shifts[0].Competence_Id = 1;
            //shifts[0].Shift_Taken_Id = -1;
            //shifts[1].Competence_Id = 2;
            //shifts[1].Shift_Taken_Id = 0;
            //shifts[1].Name = "Høvler";
            
            //foreach (var item in db.Shifts)
            //{
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine("taken_id" + item.Shift_Taken_Id);
            //}
            
            return db.Shifts;
        }
        public void AddShift(Shift shift)
        {
            var sql = $"INSERT INTO shift VALUES('{shift.Name}',{shift.Competence_Id}, {shift.Shift_Id}," +
              $"{shift.Shift_Taken_Id},'{shift.Start_Date.ToString("MM-dd-yyyy")}','{shift.End_Date.ToString("MM-dd-yyyy")}')";
            Console.WriteLine("Add shift sql: " + sql);
            db.CUD(sql);
        }

        public bool DeleteShift(int id)
        {
            //foreach (var shift in db.Shifts)
            //{
            //    if (shift.Shift_Id == id)
            //    {
            //        db.CUD("sql things....");
            //        return true;
            //    }
            //}
            string sql = $"DELETE FROM shift WHERE shift_id = {id}";
            Console.WriteLine(sql);
            db.CUD(sql);
            return false;
        }

        public bool UpdateShift(Shift shift)
        {
            //string sqlQuery = $"UPDATE items " +
            //    $"SET name = '{item.Name}', quantity = {item.Quantity}" +
            //    $", havebought = {item.HaveBought}" +
            //    $" WHERE id = {item.Id}";
            //int rows = db.conn.Execute(sqlQuery);
            // return rows > 0;
             string sql = $"UPDATE shift SET name = '{shift.Name}', competence_id = {shift.Competence_Id}, shift_taken_id = {shift.Shift_Taken_Id}," +
                $"start_time = '{shift.Start_Date.ToString("MM-dd-yyyy")}', end_time = '{shift.End_Date.ToString("MM-dd-yyyy")}' WHERE shift_id = {shift.Shift_Id}";

            Console.WriteLine("Update shift sql: " + sql);

              db.CUD(sql);


            return false;
        }
    }
}

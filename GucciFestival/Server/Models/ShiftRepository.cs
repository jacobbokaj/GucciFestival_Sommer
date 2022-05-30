using GucciFestival.Server.Services;
using GucciFestival.Shared.Models;

namespace GucciFestival.Server.Models
{
    public class ShiftRepository : IShiftRepository
    {
        PgAdminDBContext db = new  PgAdminDBContext();
        public List<Shift> GetAllShifts()
        {
            db.GetAllShifts("SELECT name, start_time, end_time, description, competence_id, shift_id FROM shift");
            List<Shift> shifts = new List<Shift>();
            shifts.Add(new Shift());
            shifts.Add(new Shift());
            shifts[0].Name = "Pandekager";
            shifts[1].Name = "Høvler";
            return shifts;
        }
        public void AddShift(Shift shift)
        {
            throw new NotImplementedException();
        }

        public bool DeleteShift(int id)
        {
            foreach (var shift in db.Shifts)
            {
                if (shift.Shift_Id == id)
                {
                    db.CUD("sql things....");
                    return true;
                }
            }
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
            return false;
        }
    }
}

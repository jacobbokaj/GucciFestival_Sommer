using GucciFestival.Server.Services;
using GucciFestival.Shared.Models;

namespace GucciFestival.Server.Models
{
    public class ShiftRepository : IShiftRepository
    {
        PgAdminDBContext db = new  PgAdminDBContext();
        public List<Shift> GetAllShifts()
        {
            Console.WriteLine("GetAllShifts From server");
            List<Shift> shifts = db.Shifts;
            return shifts;
        }
        public List<Shift> AddShift()
        {
            throw new NotImplementedException();
        }
    }
}

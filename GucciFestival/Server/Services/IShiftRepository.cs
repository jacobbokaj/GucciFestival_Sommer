using GucciFestival.Shared.Models;

namespace GucciFestival.Server.Services
{
    public interface IShiftRepository
    {
        List<Shift> GetAllShifts();
        void AddShift(Shift shift);
    }
}

using GucciFestival.Shared.Models;

namespace GucciFestival.Server.Services
{
    public interface IShiftRepository
    {
        List<Shift> GetAllShifts();
        void AddShift(Shift shift);
        bool DeleteShift(int id);
        bool UpdateShift(Shift shift);
    }
}

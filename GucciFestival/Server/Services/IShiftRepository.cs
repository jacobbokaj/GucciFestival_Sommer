using GucciFestival.Shared.Models;

namespace GucciFestival.Server.Services
{
    public interface IShiftRepository
    {
        List<Shift> GetAllShifts();
        List<Shift> AddShift();
    }
}

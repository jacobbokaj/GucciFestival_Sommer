using GucciFestival.Shared.Models;

namespace GucciFestival.Client.Services
{
    public interface IShiftService
    {
        public Task<Shift[]?> GetAllShifts();

        Task<int> AddShift(Shift shift);

        Task<int> DeleteShift(Shift shift);
        Task<int> UpdateShift(Shift shift);
    }
}

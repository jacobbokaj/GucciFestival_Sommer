using GucciFestival.Server.Models;
using GucciFestival.Server.Services;
using GucciFestival.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace GucciFestival.Server.Controllers
{
    public class ShiftController : ControllerBase
    {
        private readonly IShiftRepository Repository = new ShiftRepository();

        public ShiftController(IShiftRepository shiftRepository)
        {
            if (shiftRepository != null)
            {
                Repository = shiftRepository;
            }
        }

        [HttpGet]
        public IEnumerable<Shift> GetAllShifts()
        {
            return Repository.GetAllShifts();
        }

    }
}

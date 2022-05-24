using GucciFestival.Server.Models;
using GucciFestival.Server.Services;
using GucciFestival.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace GucciFestival.Server.Controllers
{
    [ApiController]
    [Route("api/shiftapi")]
    public class ShiftController : ControllerBase
    {
        private readonly IShiftRepository Repository = new ShiftRepository();

        public ShiftController(IShiftRepository shiftRepository)
        {
            Console.WriteLine("Connection");
            if (shiftRepository != null)
            {
                Repository = shiftRepository;
            }
        }

        [HttpGet]
        public IEnumerable<Shift> GetAllShifts()
        {
            Console.WriteLine("ConnectionGet");
            return Repository.GetAllShifts();
        }

        [HttpGet]
        public IEnumerable<Shift> AddShift()
        {
            return Repository.AddShift();
        }
    }
}

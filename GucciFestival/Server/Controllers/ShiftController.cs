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

        private readonly IShiftRepository repository = null;


        public ShiftController(IShiftRepository shiftRepository)
        {
            if (shiftRepository != null)
            {
                //Henter classen shiftRepository for at få adgang til alle dapper metoderne, som har forespørgelser til pgadmin/sql.
                repository = shiftRepository;
            }
        }

        [HttpGet]
        public IEnumerable<Shift> GetAllShifts()
        {
            
            return repository.GetAllShifts();
        }

        [HttpPost]
        public void AddShift(Shift shift)
        {
         
            repository.AddShift(shift);
        }

        [HttpDelete("{id:int}")]
        public void DeleteShift(int id)
        {
          
            repository.DeleteShift(id);
        }
        [HttpPut]
        public void Update(Shift shift)
        {

            repository.UpdateShift(shift);
        }
    }
}

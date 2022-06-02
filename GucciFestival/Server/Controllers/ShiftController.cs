﻿using GucciFestival.Server.Models;
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
            Console.WriteLine("Connection");
            if (shiftRepository != null)
            {
                repository = shiftRepository;
            }
        }

        [HttpGet]
        public IEnumerable<Shift> GetAllShifts()
        {
            Console.WriteLine("ConnectionGet");
            return repository.GetAllShifts();
        }

        [HttpPost]
        public void AddShift(Shift shift)
        {
            Console.WriteLine("Update HTTPPOST");
            repository.AddShift(shift);
        }

        [HttpDelete("{id:int}")]
        public void DeleteShift(int id)
        {
            Console.WriteLine("DELETE HTTPDELETE");
            repository.DeleteShift(id);
        }
        [HttpPut]
        public void Update(Shift shift)
        {
            Console.WriteLine("Update HTTPPUT");
            repository.UpdateShift(shift);
        }
    }
}

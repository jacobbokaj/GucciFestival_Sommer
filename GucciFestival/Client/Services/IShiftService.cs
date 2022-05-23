﻿using GucciFestival.Shared.Models;

namespace GucciFestival.Client.Services
{
    interface IShiftService
    {
        public Task<Shift[]?> GetAllShifts();

        Task<int> AddShift(Shift shift);
    }
}

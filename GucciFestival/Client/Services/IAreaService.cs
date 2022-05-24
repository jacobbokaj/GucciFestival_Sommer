﻿using GucciFestival.Shared.Models;

namespace GucciFestival.Client.Services
{
    public interface IAreaService
    {
        public Task<Area[]?> GetAllAreas();
    }
}

﻿using GucciFestival.Server.Models;
using GucciFestival.Server.Services;
using GucciFestival.Shared.Models;
using Microsoft.AspNetCore.Mvc;


namespace GucciFestival.Server.Controllers
{
    [ApiController]
    [Route("api/volunteerapi")]
    public class VolunteerController : ControllerBase
    {

        private readonly IVolunteerRepository Repository = new VolunteerRepository();

        public VolunteerController(IVolunteerRepository volunteerRepository)
        {
            if (volunteerRepository != null)
            {
                Repository = volunteerRepository;
            }
        }
        [HttpGet]
        public IEnumerable<Volunteer> GetAllVolunteers()
        {
            return Repository.GetAllVolunteers();
        
        }
        [HttpPost]
        public IEnumerable<Volunteer> AddVolunteer()
        {
            return Repository.AddVolunteer();
        }
    }
}

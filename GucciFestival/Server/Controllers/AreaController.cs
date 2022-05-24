using GucciFestival.Server.Models;
using GucciFestival.Server.Services;
using GucciFestival.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace GucciFestival.Server.Controllers
{
    [ApiController]
    [Route("api/areaapi")]
    public class AreaController : ControllerBase
    {
        private readonly IAreaRepository Repository = new AreaRepository();

        public AreaController(IAreaRepository areaRepository)
        {
            if (areaRepository != null)
            {
                Repository = areaRepository;
                Console.WriteLine("Connection Area");
            }
        }

        [HttpGet]
        public IEnumerable<Area> GetAllAreas()
        {
            return Repository.GetAllAreas();
        }
    }
}

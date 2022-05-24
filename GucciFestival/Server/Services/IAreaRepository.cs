using GucciFestival.Server.Models;
using GucciFestival.Server.Services;
using GucciFestival.Shared.Models;

namespace GucciFestival.Server.Services
{
    public interface IAreaRepository
    {
        List<Area> GetAllAreas();
    }
}

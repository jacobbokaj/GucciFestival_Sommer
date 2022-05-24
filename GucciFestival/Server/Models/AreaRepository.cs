using GucciFestival.Server.Models;
using GucciFestival.Server.Services;
using GucciFestival.Shared.Models;

namespace GucciFestival.Server.Models
{
    public class AreaRepository : IAreaRepository
    {
        PgAdminDBContext db = new PgAdminDBContext();
        public List<Area> GetAllAreas()
        {

            List<Area> list = db.Areas;
            return list;
        }
    }
}

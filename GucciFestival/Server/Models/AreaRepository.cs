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
            List<Area> list = new List<Area>();
            list.Add(new Area());
            list[0].Name = "lets go";
            //List<Area> list = db.Areas;
            return list;
        }
        public void AddArea(Area area)
        {
            throw new NotImplementedException();
        }
    }
}

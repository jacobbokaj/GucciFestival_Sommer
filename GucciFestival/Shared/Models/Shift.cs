using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GucciFestival.Shared.Models
{
    public class Shift
    {
        private int id;
        public int Id { get => id; private set => id = value; }

        private string name;
        private DateTime startDate;
        private DateTime endDate;

        private string description;
        private string task;
        private VolunteerService voolunteerService;
        public int cake;
    }
}

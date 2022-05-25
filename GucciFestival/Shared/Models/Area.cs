using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GucciFestival.Shared.Models
{
    public class Area
    {
        private int id;
        private string name;
        private List<Shift> shifts;
        private User user;
        private string description;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public List<Shift> Shifts { get => shifts; set => shifts = value; }
        public User User { get => user; set => user = value; }
        public string Description { get => description; set => description = value; }
    }
}

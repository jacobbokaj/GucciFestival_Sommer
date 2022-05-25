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

        private string name = "WWWW";
        public string Name { get => name;}

        private DateTime startDate;
        private DateTime endDate;

        private string description;
        private string task;
        private string competence;
        public string cake;
        //  private VolunteerService voolunteerService;


        public Shift()
        {

        }
        
    }
}

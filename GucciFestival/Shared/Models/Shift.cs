using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GucciFestival.Shared.Models
{
    public class Shift
    {
      

        
        public string Name { get; set; }

        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }

        public int Competence_Id { get; set; }


        public int Shift_Id { get; set; }

        public int Shift_Taken_Id { get; set; }
        //  private VolunteerService voolunteerService;
        

        public Shift()
        {

        }
        
    }
}

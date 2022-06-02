using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GucciFestival.Shared.Competences;

namespace GucciFestival.Shared.Models
{
    public class User
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int Phone { get;  set; }

        public DateTime Birthday { get; set; }
        //public int? Competence_id;
        public int User_id { get; set; }
        public int? Type_id { get; set; }
        public string? Type { get; set; }

        public List<int> Competences_Id { get; set; } = new List<int>();
        /// <summary>
        /// false for volunteer, true for Coordinator.
        /// </summary>
        //public bool CoordinatorFlag { get; private set; }
        //public User(string name, DateTime birthDate, string email, int tlf, bool coordinatorFlag = false)
        //{
        //    Name = name;
        //    BirthDate = birthDate;
        //    Email = email;
        //    Tlf = tlf;

        //    CoordinatorFlag = coordinatorFlag;
        //}
     
        public User()
        {

        }
        
    }
}

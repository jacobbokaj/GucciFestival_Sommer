using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GucciFestival.Shared.Models
{
    public class User
    {
        public string? Name { get; private set; }
        public DateTime? Birthday { get; private set; } = DateTime.Now;
        public string? Email { get; private set; }
        public int? Tlf { get; private set; }

        public string? Password;
        public int? Competence_id;
        public int? User_id;
        public int? Type_id;
        public string? Type;

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
        //public User(string name, string email, int tlf, string password, int competence_id, int user_id, int type_id, string type)
        //{
        //    Name = name;

        //    Email = email;
        //    Tlf = tlf;
        //    Password = password;
        //    Competence_id = competence_id;
        //    User_id = user_id;
        //    Type_id = type_id;
        //    Type = type;
        //    Birthday = DateTime.Now;
        //}
        public User()
        {

        }
        
    }
}

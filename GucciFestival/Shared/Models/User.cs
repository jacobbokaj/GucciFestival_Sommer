using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GucciFestival.Shared.Models
{
    public class User
    {
        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Email { get; private set; }
        public int Tlf { get; private set; }
        //public User(string name, DateTime birthDate, string email, int tlf)
        //{
        //    Name = name;
        //    BirthDate = birthDate;
        //    Email = email;
        //    Tlf = tlf;
        //}
    }
}

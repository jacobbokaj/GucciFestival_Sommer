using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GucciFestival.Shared.Models
{
    public class User_v2
    {
        public string? First_name { get; set; }
        public string? Password { get; set; }
        public User_v2(string first_name, string password)
        {
            First_name = first_name;
            Password = password;
        }
    }
}

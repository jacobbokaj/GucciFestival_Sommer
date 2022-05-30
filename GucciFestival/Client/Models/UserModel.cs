using GucciFestival.Shared.Models;
using System.ComponentModel.DataAnnotations;
using GucciFestival.Shared.Competences;

namespace GucciFestival.Client.Models
{
    //Hej
    public class UserModel
    {
        [Required]
        public string Name { get; set; }
        public DateTime Birthday { get; set; } = DateTime.Now;

        public string Email { get; set; }

        public int Tlf { get; set; }

        public string Password { get; set; }

        public List <Competences> Competencelist { get; set; }
    }
}

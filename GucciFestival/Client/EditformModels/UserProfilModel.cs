using GucciFestival.Shared.Models;
using System.ComponentModel.DataAnnotations;
using GucciFestival.Shared.Competences;

namespace GucciFestival.Client.Models
{
    //Hej
    public class UserProfilModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public int Phone { get; set; }
        [Required]
        public DateTime Birthday { get; set; } = DateTime.Now;

        public List<int> Competence_Id { get; set; } = new List<int>();
    }
}

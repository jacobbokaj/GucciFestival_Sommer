using System.ComponentModel.DataAnnotations;

namespace GucciFestival.Client.Models
{
    public class UserModel
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

        public UserModel()
        {
            Name = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
            Phone = 0;
        }
    }
}

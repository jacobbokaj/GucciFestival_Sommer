using System.ComponentModel.DataAnnotations;

namespace GucciFestival.Client.EditformModels
{
    public class ShiftModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime Start_Time { get; set; } = DateTime.Now;
        [Required]
        public DateTime End_Time { get; set; } = DateTime.Now;
    }
}

using System.ComponentModel.DataAnnotations;

namespace GucciFestival.Client.EditformModels
{
    public class ShiftModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime Start_Date { get; set; } = DateTime.Now;
        [Required]
        public DateTime End_Date { get; set; } = DateTime.Now;
    }
}

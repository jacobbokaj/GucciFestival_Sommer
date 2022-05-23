namespace GucciFestival.Client.Models
{
    public class ShiftService
    {
        private int id;
        public int Id { get => id; private set => id = value; }

        private string name;
        private DateTime startDate;
        private DateTime endDate;

        private string description;
        private string task;
        private VolunteerService voolunteerService;

    }
}

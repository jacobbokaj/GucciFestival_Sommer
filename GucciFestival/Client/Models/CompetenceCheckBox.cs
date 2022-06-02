namespace GucciFestival.Client.Models
{
    public class CompetenceCheckBox
    {
        public CompetenceCheckBox(int index,bool flag)
        {
            CompetenceIndex = index;
            HaveCompetenceFlag = flag;
        }
        public int CompetenceIndex { get; set; }
        public bool HaveCompetenceFlag { get; set; }
    }
}

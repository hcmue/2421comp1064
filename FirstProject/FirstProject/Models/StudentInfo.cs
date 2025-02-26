namespace FirstProject.Models
{
    public class StudentInfo
    {
        public string StudentId { get; set; }
        public string FullName { get; set; }
        public double Mark { get; set; }
        public string? GPA
        {
            get {
                if (Mark >= 8.5) return "A";
                else if(Mark >= 7.8) return "B+";
                return "D";
            }
        }
    }
}

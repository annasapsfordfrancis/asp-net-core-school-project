namespace SchoolProject
{
    public class Pupil
    {
        public int PupilId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int YearGroup { get; set; }
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
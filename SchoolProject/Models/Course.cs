namespace SchoolProject
{
    public class Course
    {
        public int CourseId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        // public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public ICollection<Pupil> Pupils { get; set; } = new List<Pupil>();
    }
}
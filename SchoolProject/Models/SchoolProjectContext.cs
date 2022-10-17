using Microsoft.EntityFrameworkCore;

namespace SchoolProject
{
    public class SchoolProjectContext : DbContext
    {
        public SchoolProjectContext(DbContextOptions<SchoolProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Pupil>? Pupils { get; set; }
        public DbSet<Teacher>? Teachers { get; set; }
        public DbSet<Course>? Courses { get; set; }
    }
}
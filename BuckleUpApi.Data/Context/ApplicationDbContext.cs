using BuckleUpApi.Core.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BuckleUpApi.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<PersonalUser> PersonalUsers { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<QuizParticipant> QuizParticipants { get; set; }
        public DbSet<StudentAssessment> StudentAssessments { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<TeacherCourse> TeacherCourses { get; set; }
        public DbSet<TeacherStudent> TeacherStudents { get; set; }
        public DbSet<AssessmentQuestion> AssessmentQuestions { get; set; }
        public DbSet<QuizQuestion> QuizQuestions { get; set; }

    }
}
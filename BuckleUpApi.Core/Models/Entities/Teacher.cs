using System;
using System.Collections.Generic;

namespace BuckleUpApi.Core.Models.Entities
{
    public class Teacher : Details
    {

        public Teacher()
        {
            Courses = new List<Course>();
            Assessments = new List<Assessment>();
            TeacherStudents = new List<TeacherStudent>();
        }
        public User User { get; set; }
        public Guid UserId { get; set; } 
        public ICollection<Course> Courses { get; set; }
        public ICollection<TeacherStudent> TeacherStudents { get; set; }
        public ICollection<Assessment> Assessments { get; set; }
    }
}
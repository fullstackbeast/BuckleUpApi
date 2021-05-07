using System;


namespace BuckleUpApi.Core.Models.Entities
{
    public class StudentCourse
    {
        public Guid StudentId {get; set;}
        public Student Student {get; set;}

        
        public Guid CourseId {get; set;}
        public Course Course {get; set;}

        public bool IsEnrolled {get; set;} = true;
        
    }
}
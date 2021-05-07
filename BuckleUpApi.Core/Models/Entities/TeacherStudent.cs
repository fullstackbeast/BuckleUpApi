using System;

namespace BuckleUpApi.Core.Models.Entities
{
    public class TeacherStudent
    {
        public Guid TeacherId{get; set;}
        public Teacher Teacher {get; set;}

        public Guid StudentId{get; set;}
        public Student Student{get; set;}


        public string Status {get; set;} = "active";
        
    }
}
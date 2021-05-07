using System;

namespace BuckleUpApi.Core.Models.Entities
{
    public class StudentAssessment
    {
        public Guid StudentId {get; set;}
        public Student Student{get; set;}
        public Guid AssessmentId {get; set;}
        public Assessment Assessment{get; set;}
        public bool HasTaken { get; set; } = false;
        public int score { get; set;} = 0;
        public int NumberOfQuestionsWhenTaken { get; set;}
        public string Status {get; set;}
        public string Answers {get; set;}
    }
}
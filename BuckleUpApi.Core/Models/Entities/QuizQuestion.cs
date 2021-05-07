using System;

namespace BuckleUpApi.Core.Models.Entities
{
    public class QuizQuestion: Question
    {
        public Guid QuizId {get; set;}
        public Quiz Quiz {get; set;}
        
    }
}
using System;

namespace BuckleUpApi.Core.Models.Entities
{
    public class AssessmentQuestion : Question
    {
         public Guid AssessmentId {get; set;}
        public Assessment Assessment {get; set;} 
    }
}
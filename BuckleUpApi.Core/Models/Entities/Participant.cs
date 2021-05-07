using System.Collections.Generic;

namespace BuckleUpApi.Core.Models.Entities
{
    public class Participant : BaseEntity
    {
        public Participant()
        {
            QuizParticipants = new List<QuizParticipant>();
        }

        public string Name {get; set;}
        public ICollection<QuizParticipant> QuizParticipants { get; set; }
    }
}
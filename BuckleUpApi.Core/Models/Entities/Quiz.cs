using System;
using System.Collections.Generic;

namespace BuckleUpApi.Core.Models.Entities
{
    public class Quiz : BaseEntity
    {
        public Quiz()
        {
            Questions = new List<QuizQuestion>();
            QuizParticipants = new List<QuizParticipant>();
        }

        public User User {get; set;}
        public Guid UserId {get; set;}
        public string CreatorRole { get; set; }
        public string Link { get; set; }
        public ICollection<QuizQuestion> Questions { get; set; }
        public ICollection<QuizParticipant> QuizParticipants { get; set; }
        public string status { get; set; }
        public bool ShowParticipantResult { get; set; } = false;

    }
}
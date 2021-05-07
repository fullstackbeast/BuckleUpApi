using System;

namespace BuckleUpApi.Core.Models.Entities
{
    public class QuizParticipant
    {
        public Quiz Quiz {get; set;}
        public Guid QuizId{get; set;}

        public Participant Participant{get; set;}
        public Guid ParticipantId{ get; set;}

        public int Score{ get; set;}
        public bool HasPlayed{ get; set;} = false;
    }
}
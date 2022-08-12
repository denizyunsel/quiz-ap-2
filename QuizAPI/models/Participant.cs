using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAPI.models
{
    public class Participant
    {
        [key]

        public int participantId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Name { get; set; }
        public int Score { get; set; }
        public int TimeTaken { get; set; }


    }
    public class ParticipantRestult
    {
        public int ParticipantId { get; set; }

        public int Score { get; set; }

        public int TimeTaken { get; set; }
    }
}

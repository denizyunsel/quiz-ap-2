using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAPI.models
{
    public class Question
    {
        [Key]
        public int QnId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string QnInWords { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string? ImageName { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string option1 { get; set; }
        public string Option1 { get; internal set; }
        [Column(TypeName = "nvarchar(250)")]
        public string option2 { get; set; }
        public string Option2 { get; internal set; }
        [Column(TypeName = "nvarchar(250)")]
        public string option3 { get; set; }
        public string Option3 { get; internal set; }
        [Column(TypeName = "nvarchar(250)")]
        public string option4 { get; set; }
        public string Option4 { get; internal set; }
        public int Answer { get; set; }

    }
}

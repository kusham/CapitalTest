using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CapitalTest.Models
{
    public class Questions
    {
        [JsonProperty("id")]
        public required Guid Id { get; set; }
        [Required(ErrorMessage = "Question type is required")]
        public required QuestionType QuestionType { get; set; }
        [Required(ErrorMessage = "Question Title is required")]
        public required string QuestionTitle { get; set; }
        [DefaultValue(true)]
        public bool Visibility { get; set; }
        [Required]
        public Guid ProgramId { get; set; }
    }

    public enum QuestionType
    {
        Paragraph = 1,
        YesNo = 2,
        Dropdown = 3,
        MultipleChoice = 4,
        Date = 5,
        Number = 6
    }
}

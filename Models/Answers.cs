namespace CapitalTest.Models
{
    public class Answers
    {
        public required Guid Id { get; set; }
        public required string Answer { get; set; }
        public required Guid UserId { get; set; }
        public required Guid QuestionId { get; set; }
    }
}

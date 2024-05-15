using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace CapitalTest.Models
{
    public class Programs
    {
        [JsonProperty("id")]
        public required Guid Id { get; set; }
        [Required(ErrorMessage = "Program title is required")]
        public required string ProgramTitle { get; set; }
        [Required(ErrorMessage = "Program description is required")]
        public required string ProgramDescription { get; set; }
        public ICollection<Questions> Questions { get; set; } = [];
    }
}

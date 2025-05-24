using System.ComponentModel.DataAnnotations;

namespace TaskApi.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public required string Title { get; set; }

        [MaxLength(250)]
        public required string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public TodoStatus Status { get; set; }

        public int AuthorId { get; set; }
        public string? Author { get; set; }
    };

    
}

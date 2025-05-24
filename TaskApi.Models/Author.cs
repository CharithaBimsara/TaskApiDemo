using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApi.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public required string FullName { get; set; }

        [MaxLength(10)]
        public required string AddressNo { get; set; }

        [MaxLength(255)]
        public required string City { get; set; }

        [MaxLength(255)]
        public required string Region { get; set; }

        [Required, MaxLength(255)]
        public string JobRole { get; set; }

        public ICollection<Todo> Todos { get; set; } = new List<Todo>();    


    }
}

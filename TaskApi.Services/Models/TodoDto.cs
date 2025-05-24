using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApi.Models;

namespace TaskApi.Services.Models
{
    public class TodoDto
    {
        public int Id { get; set; }      
        public required string Title { get; set; }      
        public required string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Status { get; set; }
        public int AuthorId { get; set; }        
    }
}

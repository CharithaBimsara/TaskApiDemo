using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApi.Models;

namespace TaskApi.Services.Models
{
    public class AuthorDto
    {

        public int Id { get; set; }
        public required string FullName { get; set; }
        public string Address { get; set; }

        public string JobRole { get; set; }

       

       
    }
}

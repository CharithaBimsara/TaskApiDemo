using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskApi.Models
{
    public class Author
    {
        public int Id { get; set; }
        public required string FullName { get; set; }

    }
}

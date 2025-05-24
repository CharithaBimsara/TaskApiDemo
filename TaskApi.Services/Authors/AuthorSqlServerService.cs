using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApi.DataAcess;
using TaskApi.Models;

namespace TaskApi.Services.Authors
{
  
    public class AuthorSqlServerService : IAuthorRepository
    {
        private readonly TodoDbContext _context = new TodoDbContext();

        public List<Author> GetAllAuthors()
        {
            return _context.Authors.ToList();
        }

        public List<Author> GetAllAuthors(string job)
        {
            if (string.IsNullOrWhiteSpace(job))
            {
                return GetAllAuthors();
            }
            job = job.Trim();

            return _context.Authors.Where(a => a.JobRole == job).ToList();
        }

        public Author GetAuthor(int id)
        {
            return _context.Authors.Find(id);
        }
    }
}

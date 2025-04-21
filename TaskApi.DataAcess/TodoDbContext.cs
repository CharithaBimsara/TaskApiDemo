using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskApi.Models;

namespace TaskApi.DataAcess
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = "Server=localhost;Database=TodoDb;Trusted_Connection=True;;Encrypt=False";

       
            optionsBuilder.UseSqlServer(connection);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().HasData(new Todo
            {
                Id = 1,
                Title = "Get books fro school - DB",
                Description = "B",
                CreatedDate = new DateTime(2024, 01, 01), // Static value
                UpdatedDate = new DateTime(2024, 01, 06), // Static value
                Status = TodoStatus.New
            });
        }

    }
}

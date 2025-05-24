using Microsoft.EntityFrameworkCore;
using TaskApi.Models;

namespace TaskApi.DataAcess
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = "Server=localhost;Database=TodoDb;Trusted_Connection=True;;Encrypt=False";


            optionsBuilder.UseSqlServer(connection);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author[]
            {
                new Author
                {
                    Id = 1,
                    FullName = "Charitha",
                    AddressNo = "10",
                    City = "Kandy",
                    Region = "Sri lanka",
                    JobRole = "Developer"


                },
                new Author
                {
                    Id = 2,
                    FullName = "Bimsara",
                    AddressNo = "10",
                    City = "Kandy",
                    Region = "Sri lanka",
                    JobRole = "QA"


                },
                new Author
                {
                    Id = 3,
                    FullName = "Adikari",
                    AddressNo = "10",
                    City = "Kandy",
                    Region = "Sri lanka",
                    JobRole = "Developer"

                },


            });

            modelBuilder.Entity<Todo>().HasData(new Todo[]
            {
                new Todo
                {
                    Id = 1,
                    Title = "Get books fro school - DB",
                    Description = "B",
                    CreatedDate = new DateTime(2024, 01, 01), // Static value
                    UpdatedDate = new DateTime(2024, 01, 06), // Static value
                    Status = TodoStatus.New,
                    AuthorId = 1,

                },

                new Todo
                {
                    Id = 2,
                    Title = "Need Some grocceries",
                    Description = "B",
                    CreatedDate = new DateTime(2024, 01, 01), // Static value
                    UpdatedDate = new DateTime(2024, 01, 06), // Static value
                    Status = TodoStatus.New,
                    AuthorId = 1,
                },

                new Todo
                {
                    Id = 3,
                    Title = "Purchase Camera",
                    Description = "B",
                    CreatedDate = new DateTime(2024, 01, 01), // Static value
                    UpdatedDate = new DateTime(2024, 01, 06), // Static value
                    Status = TodoStatus.New,
                    AuthorId = 2,
                },

            });
        }

    }
}

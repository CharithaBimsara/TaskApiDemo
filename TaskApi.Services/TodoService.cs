using TaskApi.Models;

namespace TaskApi.Services
{
    public class TodoService : ITodoRepository
    {
        public List<Todo> AllTodos() 
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "A",
                Description = "B",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now.AddDays(5),
                Status = TodoStatus.New
            };
            todos.Add(todo1);

            var todo2 = new Todo
            {
                Id = 2,
                Title = "B",
                Description = "C",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now.AddDays(5),
                Status = TodoStatus.Completed
            };
            todos.Add(todo2);

            var todo3 = new Todo
            {
                Id = 3,
                Title = "C",
                Description = "D",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now.AddDays(5),
                Status = TodoStatus.Inprogress
            };
            todos.Add(todo3);

            return todos;
        }
    }
}

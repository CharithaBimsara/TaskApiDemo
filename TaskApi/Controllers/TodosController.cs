using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskApi.Services.Todos;

namespace TaskApi.Controllers
{
    [Route("api/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _todoService;

        public TodosController(ITodoRepository repository)
        {
            _todoService = repository;
        }

        [HttpGet("{id?}")]
        public IActionResult GetTodos(int? id)
        {
            var myTodos = _todoService.AllTodos();

            if (id is null) return Ok(myTodos);

            myTodos = _todoService.AllTodos().Where(t => t.Id == id).ToList();

            return Ok(myTodos);
        }
       
        

    }


}

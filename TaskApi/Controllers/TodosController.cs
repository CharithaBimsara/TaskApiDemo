using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TaskApi.Services.Models;
using TaskApi.Services.Todos;

namespace TaskApi.Controllers
{
    [Route("api/authors/{authorId}/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _todoService;
        private readonly IMapper _mapper;

        public TodosController(ITodoRepository repository, IMapper mapper)
        {
            _todoService = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<TodoDto>> GetTodos(int authorId)
        {
            var myTodos = _todoService.AllTodos(authorId);
            var mappedTodo = _mapper.Map<ICollection<TodoDto>>(myTodos);
            return Ok(mappedTodo);
        }

        [HttpGet("{id}")]
        public IActionResult GetTodo(int authorid, int id)
        {

            var myTodo = _todoService.GetTodo(authorid, id);
            if (myTodo == null)
            {
                return NotFound();
            }

            var mappedTodo = _mapper.Map<TodoDto>(myTodo);

            return Ok(mappedTodo);
        }



    }


}

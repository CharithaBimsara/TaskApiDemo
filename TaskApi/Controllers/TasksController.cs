using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        public IActionResult Task()
        {
            var tasks = new string[] { "Task1", "Task2", "Task3" };
            return Ok(tasks);
        }

        [HttpPost]
        public IActionResult CreateTask() {
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateTask()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteTask() 
        {
            return Ok();
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskApi.Services.Authors;

namespace TaskApi.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;
        public AuthorsController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        [HttpGet]
        public IActionResult GetAuthors()
        {
            var authors = _authorRepository.GetAllAuthors();
            return Ok(authors);
        }
        [HttpGet ("{id}")]
        public IActionResult GetAuthor(int id)
        {
            var author = _authorRepository.GetAuthor(id);
            return Ok(author);
        }
    }
}

using System.Collections.ObjectModel;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskApi.Services.Authors;
using TaskApi.Services.Models;

namespace TaskApi.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;
        public AuthorsController(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
           
        }

        [HttpGet]
        public ActionResult<ICollection<AuthorDto>> GetAllAuthors([FromQuery(Name = "job")] string? job = null)
        {
            var authors = _authorRepository.GetAllAuthors(job);
            var mappedAuthors = _mapper.Map<ICollection<AuthorDto>>(authors);

            return Ok(mappedAuthors);
        }






        [HttpGet ("{id}")]
        public IActionResult GetAuthor(int id)
        {
            var author = _authorRepository.GetAuthor(id);
            if (author == null)
            {
                return NotFound();
            }

            var mappedAuthor = _mapper.Map<AuthorDto>(author)  ; 
            return Ok(author);
        }
    }
}

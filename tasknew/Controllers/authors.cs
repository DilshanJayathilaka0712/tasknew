using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Taskapi.modles;
using Taskapi.services.authorss;
using Taskapi.services.Modles;

namespace tasknew.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class authors : ControllerBase
    {
        private readonly Iauthorrepository _servise;
        private readonly IMapper _mapper;
        public authors(Iauthorrepository servise, IMapper mapper)
        {
            _servise = servise;
            _mapper = mapper;

        }
        [HttpGet]
        public ActionResult<ICollection<authordto>> Getauthors([FromQuery] string job)
        {
            var authors = _servise.GetaAuthors(job);

            var mappauth = _mapper.Map<ICollection<authordto>>(authors);

            return Ok(mappauth);
        }
        [HttpGet("{id}",Name ="GetAuthor")]
        public IActionResult Getauthor(int id)
        {
            var author = _servise.GetAuthor(id);
            if (author is null)
            {
                return NotFound();
            }
            var mappedautor = _mapper.Map<authordto>(author);
            return Ok(mappedautor);
        }
        [HttpPost]
        public ActionResult<authordto> CreateAuthor(Createauthordto author)
        {
            var authorentity = _mapper.Map<author>(author);
            var newAuthor = _servise.Addauthor(authorentity);
            var authorforreturn = _mapper.Map<authordto>(newAuthor);
            return CreatedAtRoute("GetAuthor", new {id=authorforreturn.AId},authorforreturn);
        }

 }
}

using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Taskapi.services.Modles;
using Taskapi.services.Todos;
using tasknew.modles;


namespace tasknew.Controllers
{
    [Route("api/authors{authorid}/todos")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private Itodorepository _todoservices;
        private IMapper _mapper;

        public TodoController(Itodorepository repository,IMapper mapere)
        {
            _todoservices = repository;
            _mapper = mapere;
        }

        [HttpGet]
        public ActionResult<ICollection<tododto>> GetTodos(int autid)
        {
            
            var myTods = _todoservices.AllTodos(autid);
            var maptodos = _mapper.Map<ICollection<tododto>>(myTods);
            return Ok(maptodos);
        }
        [HttpGet("{id}")]
        public IActionResult GetTodo(int authorid, int id)
        {

            var myTod = _todoservices.GetById(authorid,id);
            if (myTod == null) { return NotFound(); }
            var maptodo=_mapper.Map<Todo>(myTod);
            return Ok(maptodo);
        }

    }
}

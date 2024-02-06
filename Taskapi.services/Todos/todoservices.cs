using tasknew.modles;

namespace Taskapi.services.Todos
{
    public class todoservices : Itodorepository
    {
        public List<Todo> AllTodos(int authorid)
        {
            var todos = new List<Todo>();
            var todo1 = new Todo
            {
                Id = 1,
                Title = "Get books for school",
                Description = "get some text books for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = Todostatus.New
            }; todos.Add(todo1);

            var todo2 = new Todo
            {
                Id = 2,
                Title = "Get Vegetable",
                Description = "get vegetable for week",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = Todostatus.New
            }; todos.Add(todo2);
            var todo3 = new Todo
            {
                Id = 3,
                Title = "Water the plants",
                Description = "Wter the plant quickly",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(1),
                Status = Todostatus.New
            }; todos.Add(todo3);
            return todos;
        }

        public Todo GetById(int authorid, int id)
        {
            throw new NotImplementedException();
        }
    }
}

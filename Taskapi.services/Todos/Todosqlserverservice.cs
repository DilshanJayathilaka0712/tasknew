using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taskapi.dataaccess;
using tasknew.modles;

namespace Taskapi.services.Todos
{
    public class Todosqlserverservice : Itodorepository
    {
        private readonly Tododbcontext _context = new Tododbcontext();

        public List<Todo> AllTodos(int authorid)
        {
            return _context.Todos.Where(t=>t.authorAId==authorid).ToList();

        }

        public Todo GetById(int authorid, int id)
        {
            return _context.Todos.FirstOrDefault(t=>t.Id==id && t.authorAId==authorid);
        }
    }
}

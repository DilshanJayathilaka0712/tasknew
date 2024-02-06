using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tasknew.modles;

namespace Taskapi.services.Todos
{
    public interface Itodorepository
    {
        public List<Todo> AllTodos(int authorid);
        public Todo GetById(int authorid,int id);
    }
}

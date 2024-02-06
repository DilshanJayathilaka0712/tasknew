using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taskapi.modles;

namespace Taskapi.services.authorss
{
    public interface Iauthorrepository
    {
        public List<author> GetAuthors();

        public List<author> GetaAuthors(string job);
        public author GetAuthor(int id);
        public author Addauthor(author author);
    }
}

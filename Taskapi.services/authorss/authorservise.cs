using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taskapi.dataaccess;
using Taskapi.modles;

namespace Taskapi.services.authorss
{
   
    public class authorservise : Iauthorrepository
    {
        private readonly Tododbcontext _context = new Tododbcontext();

        public List<author> GetAuthors()
        {
            return _context.Authors.ToList();
        }
        public List<author> GetaAuthors(string job)
        {
            if (string.IsNullOrEmpty(job))
            { 
            return GetAuthors();
            }
            job=job.Trim();
            return _context.Authors.Where(a=>a.Joberole==job).ToList();
        }

        public author GetAuthor(int id)
        {
            return _context.Authors.Find(id);
        }
        public author Addauthor(author author)
        { 
        _context.Authors.Add(author);
            _context.SaveChanges();
            return _context.Authors.Find(author.AId);
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tasknew.modles;

namespace Taskapi.services.Modles
{
    public class authordto
    {
        public int AId { get; set; }
       
        public string FullName { get; set; }
       public string adress { get; set; }
        public string Joberole { get; set; }

    }
}

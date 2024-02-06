using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tasknew.modles;

namespace Taskapi.services.Modles
{
    public class Createauthordto
    {
       
       
        public string FullName { get; set; }
        public string Addressno { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string Joberole { get; set; }
      
    }
}

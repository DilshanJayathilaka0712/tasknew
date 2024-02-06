using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Taskapi.modles;
using Taskapi.services.Modles;
using tasknew.modles;


namespace Taskapi.services.Profiles
{
    public class todoprofile : Profile
    {
        public todoprofile()
        {
            CreateMap<Todo, tododto>();
        }
    }
       
    
}

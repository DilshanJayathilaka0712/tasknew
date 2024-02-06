using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Taskapi.modles;
using Taskapi.services.Modles;

namespace Taskapi.services.Profiles
{
    public class authorprofile:Profile
    {
        public authorprofile()
        {
            CreateMap<author, authordto>()
            .ForMember(dest => dest.adress, op => op.MapFrom(sr => $"{sr.Addressno},{sr.street},{sr.city}"));
            CreateMap<Createauthordto, author>();
        }
    }
}

using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL
{
    internal class AutoMapperProfile:AutoMapper.Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<School, SchoolDTO>()
                .ForMember(dest => dest.Name, source => source.MapFrom(s => s.SchoolName))
                .ReverseMap().
                ForMember(dest => dest.SchoolName, source => source.MapFrom(s => s.Name));

            
        }

    }
}

using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TeamInternational.Application.Response;
using TeamInternational.Domain.Entities;

namespace TeamInternational.ApplicationService.mapping
{
    public class Automapping : Profile
    {
        public Automapping()
        {
            MappingThermalGeneratingUnit();
        }

        private void MappingThermalGeneratingUnit()
        {
            CreateMap<Blog, BlogResponse>();
            CreateMap<BlogResponse, Blog>();
        }
    }
}

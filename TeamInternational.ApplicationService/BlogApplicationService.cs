using AutoMapper;
using System.Collections.Generic;
using TeamInternational.Application.Abstraction;
using TeamInternational.Application.Response;
using TeamInternational.Domain.Abstraction;
using TeamInternational.Domain.Entities;

namespace TeamInternational.ApplicationService
{
    public class BlogApplicationService : IBlogApplicationService
    {
        private readonly IBlogDomainService blogDomainService;
        private readonly IMapper mapper;
        public BlogResponse blogResponse { get; set; }

        public BlogApplicationService(IBlogDomainService blogDomainService, IMapper mapper)
        {
            this.blogDomainService = blogDomainService;
            this.mapper = mapper;

            blogResponse = new BlogResponse
            {
                Blog = new List<Blog>()
            };
        }

        public BlogResponse Get()
        {
            blogResponse.Blog = blogDomainService.Get();            
            return blogResponse;
        }
    }
}

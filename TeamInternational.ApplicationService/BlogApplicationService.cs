using AutoMapper;
using TeamInternational.Application.Abstraction;
using TeamInternational.Application.Response;
using TeamInternational.Domain.Abstraction;

namespace TeamInternational.ApplicationService
{
    public class BlogApplicationService : IBlogApplicationService
    {
        private readonly IBlogDomainService blogDomainService;
        private readonly IMapper mapper;

        public BlogApplicationService(IBlogDomainService blogDomainService, IMapper mapper)
        {
            this.blogDomainService = blogDomainService;
            this.mapper = mapper;
        }

        public BlogResponse Get()
        {
            var blog = blogDomainService.Get();
            var blogResponse = mapper.Map<BlogResponse>(blog);

            return blogResponse;
        }
    }
}

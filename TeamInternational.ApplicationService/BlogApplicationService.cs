using TeamInternational.Application.Abstraction;
using TeamInternational.Application.Response;
using TeamInternational.Domain.Abstraction;

namespace TeamInternational.ApplicationService
{
    public class BlogApplicationService : IBlogApplicationService
    {
        private readonly IBlogDomainService blogDomainService;

        public BlogApplicationService(IBlogDomainService blogDomainService)
        {
            this.blogDomainService = blogDomainService;
        }

        public BlogResponse Get()
        {
            var response = blogDomainService.Get();
            BlogResponse blogResponse = new BlogResponse();

            return blogResponse;
        }
    }
}

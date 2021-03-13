using System;
using TeamInternational.Domain.Abstraction;
using TeamInternational.Domain.Entities;

namespace TeamInternational.DomainService
{
    public class BlogDomainService : IBlogDomainService
    {
        private readonly IBlogRepositoryService blogRepositoryService;

        public BlogDomainService(IBlogRepositoryService blogRepositoryService)
        {
            this.blogRepositoryService = blogRepositoryService;
        }

        public Blog Get()
        {
            return blogRepositoryService.Get();
        }
    }
}

using System;
using System.Linq;
using TeamInternational.Domain.Abstraction;
using TeamInternational.Domain.Entities;
using TeamInternational.RepositoryService.Context;

namespace TeamInternational.RepositoryService
{
    public class BlogRepositoryService : IBlogRepositoryService
    {
        private readonly RepositoryContext context;

        public BlogRepositoryService(RepositoryContext context)
        {
            this.context = context;
        }

        public Blog Get()
        {            
            return context.Blogs.FirstOrDefault();
        }
    }
}

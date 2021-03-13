using System;
using System.Linq;
using TeamInternational.Domain.Abstraction;
using TeamInternational.Domain.Entities;
using TeamInternational.RepositoryService.Context;

namespace TeamInternational.RepositoryService
{
    public class BlogRepositoryService : Repository<Blog>, IBlogRepositoryService
    {

        public BlogRepositoryService(RepositoryContext context) : base(context)
        {
        }

    }
}

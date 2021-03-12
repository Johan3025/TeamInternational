using System;
using TeamInternational.Domain.Abstraction;
using TeamInternational.Domain.Entities;

namespace TeamInternational.RepositoryService
{
    public class BlogRepositoryService : IBlogRepositoryService
    {
        public Blog Get()
        {
            return new Blog();
        }
    }
}

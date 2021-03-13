using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeamInternational.Domain.Abstraction;
using TeamInternational.RepositoryService.Context;

namespace TeamInternational.RepositoryService
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly RepositoryContext context;

        public Repository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<T> GetAll()
        {
            return context.Set<T>().AsNoTracking();
        }
    }
}

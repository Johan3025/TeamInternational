using System;
using System.Collections.Generic;
using System.Linq;
using TeamInternational.Domain.Abstraction;
using TeamInternational.Domain.Entities;

namespace TeamInternational.DomainService
{
    public class BlogDomainService : IBlogDomainService
    {
        private readonly IUnitOfWork unitOfWork;

        public BlogDomainService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IList<Blog> Get()
        {
            return unitOfWork.Blog.GetAll().ToList();
        }
    }
}

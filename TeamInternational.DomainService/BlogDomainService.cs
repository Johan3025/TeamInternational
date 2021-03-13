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

        public IList<Blog> GetAll()
        {
            return unitOfWork.Blog.GetAll().ToList();
        }


        public Blog GetPlayerById(int id)
        {
            return unitOfWork.Blog.GetByCondition(c => c.Id == id).SingleOrDefault();
        }


        public bool AddBlog(Blog blog)
        {
            unitOfWork.Blog.Create(blog);
            unitOfWork.Save();
            return true;
        }

        public bool UpdateBlog(Blog blog)
        {
            unitOfWork.Blog.Update(blog);
            unitOfWork.Save();
            return true;
        }

        public bool DeleteBlog(Blog blog)
        {
            unitOfWork.Blog.Delete(blog);
            unitOfWork.Save();
            return true;
        }
    }
}

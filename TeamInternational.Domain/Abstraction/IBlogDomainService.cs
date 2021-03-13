using System.Collections.Generic;
using TeamInternational.Domain.Entities;

namespace TeamInternational.Domain.Abstraction
{
    public interface IBlogDomainService
    {
        IList<Blog> GetAll();

        Blog GetPlayerById(int id);

        bool AddBlog(Blog blog);

        bool UpdateBlog(Blog blog);

        bool DeleteBlog(Blog blog);
    }
}

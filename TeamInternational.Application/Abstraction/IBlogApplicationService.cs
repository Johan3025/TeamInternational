using TeamInternational.Application.Request;
using TeamInternational.Application.Response;

namespace TeamInternational.Application.Abstraction
{
    public interface IBlogApplicationService
    {
        BlogResponse GetAll();

        BlogResponse GetPlayerById(int id);

        bool AddBlog(BlogRequest blog);

        bool UpdateBlog(BlogRequest blog);

        bool DeleteBlog(BlogRequest blog);
    }
}

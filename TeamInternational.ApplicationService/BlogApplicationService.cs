using AutoMapper;
using System.Collections.Generic;
using TeamInternational.Application.Abstraction;
using TeamInternational.Application.Request;
using TeamInternational.Application.Response;
using TeamInternational.Domain.Abstraction;
using TeamInternational.Domain.Entities;

namespace TeamInternational.ApplicationService
{
    public class BlogApplicationService : IBlogApplicationService
    {
        private readonly IBlogDomainService blogDomainService;
        private readonly IMapper mapper;
        public BlogResponse blogResponse { get; set; }

        public BlogApplicationService(IBlogDomainService blogDomainService, IMapper mapper)
        {
            this.blogDomainService = blogDomainService;
            this.mapper = mapper;

            blogResponse = new BlogResponse
            {
                Blog = new List<Blog>()
            };
        }

        public BlogResponse GetAll()
        {
            blogResponse.Blog = blogDomainService.GetAll();            
            return blogResponse;
        }

        public BlogResponse GetPlayerById(int id)
        {
            Blog blog = blogDomainService.GetPlayerById(id);
            blogResponse.Blog.Add(blog);
            
            return blogResponse;
        }

        public bool AddBlog(BlogRequest blogRequest)
        {
            Blog blog = blogRequest.Blog;
            bool response = blogDomainService.AddBlog(blog);
            return response;
        }

        public bool UpdateBlog(BlogRequest blogRequest)
        {
            Blog blog = blogRequest.Blog;
            bool response = blogDomainService.UpdateBlog(blog);
            return response;
        }

        public bool DeleteBlog(BlogRequest blogRequest)
        {
            Blog blog = blogRequest.Blog;
            bool response = blogDomainService.DeleteBlog(blog);
            return response;
        }
    }
}

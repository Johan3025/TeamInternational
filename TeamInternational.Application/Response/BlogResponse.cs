using System;
using System.Collections.Generic;
using System.Text;
using TeamInternational.Domain.Entities;

namespace TeamInternational.Application.Response
{
    public class BlogResponse
    {
        public IList<Blog> Blog { get; set; }
    }
}

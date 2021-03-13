using System.Collections.Generic;
using TeamInternational.Domain.Entities;

namespace TeamInternational.Domain.Abstraction
{
    public interface IBlogDomainService
    {
        IList<Blog> Get();
    }
}

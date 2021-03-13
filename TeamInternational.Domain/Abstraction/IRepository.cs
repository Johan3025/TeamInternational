using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamInternational.Domain.Abstraction
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll(); 
    }
}

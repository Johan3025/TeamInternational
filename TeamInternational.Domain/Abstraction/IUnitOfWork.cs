using System;
using System.Collections.Generic;
using System.Text;

namespace TeamInternational.Domain.Abstraction
{
    public interface IUnitOfWork
    {
        IBlogRepositoryService Blog { get; }

        void Save();
    }
}

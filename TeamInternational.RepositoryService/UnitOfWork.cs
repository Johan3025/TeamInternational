using TeamInternational.Domain.Abstraction;
using TeamInternational.RepositoryService.Context;

namespace TeamInternational.RepositoryService
{
    public class UnitOfWork : IUnitOfWork
    {
        private IBlogRepositoryService blog;
        private readonly RepositoryContext context;

        public IBlogRepositoryService Blog 
        {
            get
            {
                if (blog == null)
                {
                    blog = new BlogRepositoryService(context);
                }

                return blog;
            }
        }

        public UnitOfWork(RepositoryContext context)
        {
            this.context = context;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}

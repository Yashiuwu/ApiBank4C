using Aplication.Interface;
using Ardalis.Specification.EntityFrameworkCore;
using Persistence.Contexts;

namespace Persistence.Repository
{
    public class MyRepositoryAsync<T> : RepositoryBase<T>, IRepositoryAsync<T> where T : class
    {
        private readonly AplicationDbContexts dbContexts; 

        public MyRepositoryAsync(AplicationDbContexts dbContexts) : base(dbContexts)
        {
            this.dbContexts = dbContexts;
        }
    }
}

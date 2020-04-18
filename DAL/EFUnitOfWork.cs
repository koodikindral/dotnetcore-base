using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class EFUnitOfWork<TDbContext> : BaseUnitOfWork, IBaseUnitOfWork
        where TDbContext : DbContext
    {
        protected TDbContext UowDbContext;

        public EFUnitOfWork(TDbContext uowDbContext)
        {
            UowDbContext = uowDbContext;
        }

        public int SaveChanges()
        {
            return UowDbContext.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await UowDbContext.SaveChangesAsync();
        }
    }
}
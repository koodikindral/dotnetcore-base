using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DotnetCore.Base.DAL.EF
{
    public class EFBaseUnitOfWork<TDbContext> : BaseUnitOfWork
        where TDbContext : DbContext
    {
        protected TDbContext UOWDbContext;

        public EFBaseUnitOfWork(TDbContext uowDbContext)
        {
            UOWDbContext = uowDbContext;
        }

        public override int SaveChanges()
        {
            return UOWDbContext.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync()
        {
            return await UOWDbContext.SaveChangesAsync();
        }
    }
}
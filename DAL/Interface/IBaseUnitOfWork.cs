using System;
using System.Threading.Tasks;

namespace DotnetCore.Base.DAL.Interface
{
    public interface IBaseUnitOfWork
    {
        //get thing done!
        int SaveChanges();
        Task<int> SaveChangesAsync();

        TRepository GetRepository<TRepository>(Func<TRepository> repoCreationMethod);
    }
}
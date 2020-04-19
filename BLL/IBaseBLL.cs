using System;
using System.Threading.Tasks;

namespace DotnetCore.Base.BLL
{
    public interface IBaseBLL
    {
        Task<int> SaveChangesAsync();
        int SaveChanges();

        TService GetService<TService>(Func<TService> serviceCreationMethod);
    }
}
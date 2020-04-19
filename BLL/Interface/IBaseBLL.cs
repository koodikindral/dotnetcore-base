using System;
using System.Threading.Tasks;

namespace DotnetCore.Base.BLL.Interface
{
    public interface IBaseBLL
    {
        Task<int> SaveChangesAsync();
        int SaveChanges();

        TService GetService<TService>(Func<TService> serviceCreationMethod);
    }
}
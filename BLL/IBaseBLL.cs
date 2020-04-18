using System;
using System.Threading.Tasks;

namespace BLL
{
    public interface IBaseBLL
    {
        Task<int> SaveChangesAsync();
        int SaveChanges();

        TService GetService<TService>(Func<TService> serviceCreationMethod);
    }
}
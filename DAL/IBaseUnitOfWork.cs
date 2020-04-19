using System.Threading.Tasks;

namespace DotnetCore.Base.DAL
{
    public interface IBaseUnitOfWork
    {
        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
using System.Threading.Tasks;

namespace DAL
{
    public interface IBaseUnitOfWork
    {
        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
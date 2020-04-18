using System;
using DAL.Repositories;
using Domain;

namespace BLL.Services
{
    public interface IBaseService
    {
        // add common base methods here
    }

    public interface IBaseEntityService<TBLLEntity> : IBaseService, IBaseRepository<TBLLEntity>
        where TBLLEntity : class, IDomainEntity<Guid>, new()
    {
    }
}
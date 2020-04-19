using System;
using DotnetCore.Base.DAL.Repositories;
using DotnetCore.Base.Domain;

namespace DotnetCore.Base.BLL.Services
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
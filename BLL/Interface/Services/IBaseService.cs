using System;
using DotnetCore.Base.DAL.Interface;
using DotnetCore.Base.DAL.Interface.Repositories;

namespace DotnetCore.Base.BLL.Interface.Services
{
    public interface IBaseService
    {
        // add common base methods here
    }

    public interface IBaseEntityService<TBLLEntity> : IBaseService, IBaseRepository<Guid, TBLLEntity>
        where TBLLEntity : class, IDomainBaseEntity<Guid>, new()
    {
    }
}
using System;
using DotnetCore.Base.DAL.Interface;

namespace DotnetCore.Base.DAL
{
    public abstract class DomainBaseEntity : DomainBaseEntity<Guid>, IDomainBaseEntity
    {
    }

    public abstract class DomainBaseEntity<TKey> : IDomainBaseEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        public virtual TKey Id { get; set; } = default!;
    }
}
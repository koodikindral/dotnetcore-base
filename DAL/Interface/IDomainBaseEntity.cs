using System;

namespace DotnetCore.Base.DAL.Interface
{
    public interface IDomainBaseEntity : IDomainBaseEntity<Guid>
    {
    }

    public interface IDomainBaseEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        public TKey Id { get; set; }
    }
}
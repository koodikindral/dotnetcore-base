using System;

namespace DotnetCore.Base.DAL.Interface
{
    public interface IDomainEntityBaseMetadata : IDomainEntityBaseMetadata<Guid>
    {
    }

    public interface IDomainEntityBaseMetadata<TKey> : IDomainBaseEntity<TKey>, IDomainEntityMetadata
        where TKey : IEquatable<TKey>
    {
    }
}
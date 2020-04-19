using System;

namespace DotnetCore.Base.Domain
{
    public interface IDomainEntity : IDomainEntity<Guid>
    {
    }

    public interface IDomainEntity<TKey> : IDomainBaseEntity<TKey>, IDomainEntityMetadata
        where TKey : struct, IEquatable<TKey>
    {
    }
}
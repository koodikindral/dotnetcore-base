using System;
using DotnetCore.Base.DAL.Interface;

namespace DotnetCore.Base.DAL
{
    public abstract class DomainEntityBaseMetadata : DomainEntityBaseMetadata<Guid>
    {
    }

    public abstract class DomainEntityBaseMetadata<TKey> : IDomainEntityBaseMetadata<TKey>
        where TKey : IEquatable<TKey>
    {
        public virtual TKey Id { get; set; } = default!;
        public virtual string? CreatedBy { get; set; }
        public virtual DateTime CreatedAt { get; set; }
        public virtual string? ChangedBy { get; set; }
        public virtual DateTime ChangedAt { get; set; }
    }
}
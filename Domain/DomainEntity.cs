using System;

namespace Domain
{
    public abstract class DomainEntity : DomainEntity<Guid>
    {
    }

    public abstract class DomainEntity<TKey> : IDomainEntity<TKey>
        where TKey : struct, IEquatable<TKey>
    {
        public virtual TKey Id { get; set; }
        public virtual string? CreatedBy { get; set; }
        public virtual DateTime CreatedAt { get; set; }
        public string? ChangedBy { get; set; }
        public DateTime ChangedAt { get; set; }
        public string? DeletedBy { get; set; }
        public virtual DateTime? DeletedAt { get; set; }
    }
}
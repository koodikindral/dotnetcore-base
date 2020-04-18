using System;

namespace Domain
{
    public abstract class DomainEntityMetadata : IDomainEntityMetadata
    {
        public virtual string? CreatedBy { get; set; }
        public virtual DateTime CreatedAt { get; set; } = DateTime.Now;
        public virtual string? ChangedBy { get; set; }
        public virtual DateTime ChangedAt { get; set; }
        public virtual string? DeletedBy { get; set; }
        public virtual DateTime? DeletedAt { get; set; }
    }
}
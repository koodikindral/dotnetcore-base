using System;

namespace Domain
{
    public abstract class DomainBaseEntity : IDomainBaseEntity
    {
        public virtual Guid Id { get; set; }
    }
}
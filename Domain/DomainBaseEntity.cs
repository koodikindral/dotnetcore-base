using System;

namespace DotnetCore.Base.Domain
{
    public abstract class DomainBaseEntity : IDomainBaseEntity
    {
        public virtual Guid Id { get; set; }
    }
}
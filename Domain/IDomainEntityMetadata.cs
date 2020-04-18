using System;

namespace Domain
{
    public interface IDomainEntityMetadata
    {
        public string? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public string? ChangedBy { get; set; }
        public DateTime ChangedAt { get; set; }

        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
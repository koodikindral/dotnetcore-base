using System;

namespace DotnetCore.Base.DAL.Interface
{
    public interface IDomainEntityMetadata
    {
        public string? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public string? ChangedBy { get; set; }
        public DateTime ChangedAt { get; set; }


        /* NO SOFT UPDATES/DELETES initially
        public string? DeletedBy { get; set; }
        
        public DateTime? DeletedAt { get; set; }
        */
    }
}
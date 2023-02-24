using System;

namespace AspNetCoreHero.Abstractions.Domain
{
    public abstract class AuditableEntity : IAuditableBaseEntity
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime? LastModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        public string DeletedBy { get; set; }
        public string SystemDtl { get; set; }
        public string Extra { get; set; }
    }
}
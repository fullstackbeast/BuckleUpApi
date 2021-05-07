using System;
using BuckleUpApi.Core.Interfaces;

namespace BuckleUpApi.Core.Models
{
    public abstract class BaseEntity : IAuditBase, ISoftDeletable
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public byte[] RowVersion { get; set; }

    }
}
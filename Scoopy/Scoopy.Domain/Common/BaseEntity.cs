using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoopy.Domain.Common
{
    public abstract class BaseEntity
    {
        public Guid Id { get; protected set; }= Guid.CreateVersion7();
        public DateTime CreatedAt { get; protected set; }
        public DateTime UpdatedAt { get; protected set; }
        public bool isDeleted { get; protected set; }
        protected BaseEntity()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt=DateTime.UtcNow;
        }
        public void Delete()
        {
            isDeleted=true;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}

using System;

namespace Domain.Models
{
    public abstract class Entity<TEntity>
    {
        public TEntity Id { get; set; }
        public DateTime DataRegisto { get; set; }
        public bool Status { get; set; }
    }
}

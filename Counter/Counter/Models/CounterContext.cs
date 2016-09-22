namespace Counter.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CounterContext : DbContext
    {
        public CounterContext()
            : base("name=CounterContext")
        {
        }

        public virtual DbSet<tblCounter> tblCounters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

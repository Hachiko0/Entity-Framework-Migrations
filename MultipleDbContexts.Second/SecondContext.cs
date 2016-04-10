using System.Data.Entity;

namespace MultipleDbContexts.Second
{
    public class SecondContext : DbContext
    {
        public SecondContext()
            : base("MultipleContexts")
        {

        }

        public virtual IDbSet<SecondEntity> SecondEntity { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("second");
        }
    }

    public class SecondEntity
    {
        public string Id { get; set; }

        public string FirstProperty { get; set; }
    }
}

using System.Data.Entity;

namespace MultipleDbContexts.First
{
    public class FirstContext : DbContext
    {
        public FirstContext()
            : base("MultipleContexts")
        {

        }

        public virtual IDbSet<FirstEntity> FirstEntity { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("first");
        }
    }

    public class FirstEntity
    {
        public string Id { get; set; }

        public string FirstProperty { get; set; }
    }
}

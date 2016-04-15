using System.Data.Entity;

namespace AutomaticMigrationsToCodeBased.Database
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("name=MyDbContext")
        {
        }

        public virtual IDbSet<User> Users { get; set; }
    }


    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string RandomProperty { get; set; }
        public string RandomProperty2 { get; set; }
        public string RandomProperty3 { get; set; }
        public string RandomProperty4 { get; set; }
        public string RandomProperty5 { get; set; }
        public string RandomProperty6 { get; set; }
    }
}

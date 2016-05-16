using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace FromCodeFirst.Database
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("name=MyDbContext")
        {
        }

        public virtual IDbSet<User> Users { get; set; }
        public virtual IDbSet<Role> Roles { get; set; }
    }


    public class User : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string RandomProperty { get; set; }
        public string RandomProperty2 { get; set; }
        public string RandomProperty3 { get; set; }
        public string RandomProperty4 { get; set; }
        public string RandomProperty5 { get; set; }      
        public int FirstDevChange { get; set; }
        public int SecondDevChange { get; set; }
        public int FirstDevChange1 { get; set; }
        public int SecondDevChange1 { get; set; }
        public int FirstDevChange2 { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }

    public class Role
    {
        [Key]
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }

    public abstract class Entity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}

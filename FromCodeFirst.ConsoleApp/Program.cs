using FromCodeFirst.Database;
using System.Linq;

namespace FromCodeFirst.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new MyDbContext())
            {
                var users = db.Users.ToList();
                db.Users.Add(new User { Age = 33, FirstName = "F", LastName = "L" });
                db.SaveChanges();
            }
        }
    }
}

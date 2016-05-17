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
                System.Console.WriteLine(new string('=', 20));
                var users = db.Users.ToList();
                db.Users.Add(new User { Age = 33, FirstName = "F", LastName = "L" });
                db.SaveChanges();
                
                users.ForEach(u => System.Console.WriteLine($"{u.FirstName} {u.LastName}"));

                System.Console.WriteLine(new string('=', 20));
            }
        }
    }
}

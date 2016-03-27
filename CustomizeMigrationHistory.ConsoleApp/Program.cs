using CustomizeMigrationHistory.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomizeMigrationHistory.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new MyDbContext())
            {
                var user = db.Users.FirstOrDefault();
                Console.WriteLine(user.Name);
            }
        }
    }
}

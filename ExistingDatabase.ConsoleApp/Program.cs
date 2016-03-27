using ExistingDatabase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExistingDatabase.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            using (var db = new NorthwindDbContext())
            {
                db.Employees.ToList().ForEach(s => Console.WriteLine(s.FirstName));
            }
        }
    }
}

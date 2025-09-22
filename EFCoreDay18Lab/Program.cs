using EFCoreDay18Lab.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDay18Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            using (SchoolContext db = new SchoolContext())
            {
                var emps = db.Employees.AsNoTracking().ToList();
                foreach (var item in emps)
                {
                    Console.WriteLine($"ID {item.Id} Name {item.Name} ");
                }
                //Select 
                var emp = db.Employees.Find(1);
                //State
                Console.WriteLine(db.Entry(emp).State);
                //Change 
                emp.Name = "Sayed Hawas";
                //State
                Console.WriteLine(db.Entry(emp).State);


                //To ADD
                Employee NewEmployee = new Employee { Name = "Mariem ElSayed", age = 21 };
                db.Employees.Add(NewEmployee);
                Console.WriteLine(db.Entry(NewEmployee).State);
                //To Remove
                db.Remove(NewEmployee);
                Console.WriteLine(db.Entry(NewEmployee).State);

                Console.WriteLine(db.ChangeTracker.ToDebugString());

                db.SaveChanges();
            }

            Console.ReadLine();
        }
    }
}

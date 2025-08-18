using Day10EFCoreCodeFirstDemo.Models;

namespace Day10EFCoreCodeFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------- Entity FrameWork Core Code First----------- ");
            /*
             1)create a new .NET Core project

             2) Add NuGet Package 

                https://www.nuget.org/
                dot net add package Microsoft.EntityFrameworkCore
                dot net add package Microsoft.EntityFrameworkCore.SqlServer
                dot net add package Microsoft.EntityFrameworkCore.Tools
             
            3) Create Folder Models 

            4) Create Class Employee Entry Row (Object)
            5) Create Class MyDbContext : DbContext
            6) DbSet --> Table Entity Employee Generic 
            7) Configuration Overrid OnConfiguration into DbContext: Class
              optionsBuilder.UseSqlServer("server=SAYEDHAWAS\\DEPI2025R3;Database=EFCoreCodeFirstDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            8) Rebuild Project

            9)Open PMC Package Manager Console   View 

            10) Migration 
                Add-Migration <InitialCreate>
            11) Update Database 

             EFCore --->   DbContext     ADO.Net SQLConnection
             */
            #region Session Part 1
            //Code First  Migration 
            //LINQ
            //CRUD   Create Read Update Delete 
            using (MyDbContext db = new MyDbContext())
            {


                var EmployeesList = (from e in db.Employees
                                     where e.Id >= 1
                                     select e);
                //Read All 
                LoadData(db);

                Console.WriteLine(" -------------- Insert Employee -------------------");

                Console.Write("Enter Name : ");
                string name = Console.ReadLine();
                Console.Write("Enter Job : ");
                string job = Console.ReadLine();
                Console.Write("Enter Age : ");
                int age;
                int.TryParse(Console.ReadLine(), out age);
                Console.Write("Enter Salary : ");
                double salary;
                double.TryParse(Console.ReadLine(), out salary);

                Employee NewEmployee = new Employee() { Name = name, Age = age, Salary = salary, Job = job };

                //Create 
                db.Employees.Add(NewEmployee);
                //Commite Save 
                db.SaveChanges();
                Console.WriteLine("Insert Employee ....");
                LoadData(db);

                Console.WriteLine(" -------------- Update  Employee -------------------");
                Console.Write("Enter ID : ");
                int id;
                int.TryParse(Console.ReadLine(), out id);
                var updateEmployee = GetEmployeeByID(db, id);

                Console.Write("Enter New Name : ");
                string newName = Console.ReadLine();
                Console.Write("Enter New Job : ");
                string newJob = Console.ReadLine();
                Console.Write("Enter New Age : ");
                int newAge;
                int.TryParse(Console.ReadLine(), out newAge);
                Console.Write("Enter  New Salary : ");
                double newSalary;
                double.TryParse(Console.ReadLine(), out newSalary);



                if (updateEmployee != null)
                {
                    //Update
                    updateEmployee.Name = newName;
                    updateEmployee.Age = newAge;
                    updateEmployee.Salary = newSalary;
                    updateEmployee.Job = newJob;

                    db.SaveChanges();
                    Console.WriteLine("Update Employee ....");
                    LoadData(db);
                }

                Console.WriteLine(" -------------- Delete  Employee -------------------");
                Console.Write("Enter ID : ");
                int idDelete;
                int.TryParse(Console.ReadLine(), out idDelete);
                var DeleteEmployee = GetEmployeeByID(db, idDelete);
                if (DeleteEmployee != null)
                {
                    db.Employees.Remove(DeleteEmployee);
                    db.SaveChanges();
                    Console.WriteLine("Delete Employee ....");
                    LoadData(db);
                }

            }
            #endregion
            Console.ReadLine();

        }

        private static void LoadData(MyDbContext db)
        {
            //Read
            var EmployeeListAsLambda = db.Employees.Where(e => e.Id >= 1);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($" Counter is : {db.Employees.Count()}");
            Console.WriteLine(" -------------- Show Table -------------------");
            foreach (var item in EmployeeListAsLambda)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("----------------------------------------------");
        }

        private static Employee GetEmployeeByID(MyDbContext db, int id)
        {
            if (id == 0)
            {
                Console.WriteLine("Wrong Id ...");
                return null;
            }
            var selectEmployee = db.Employees.SingleOrDefault(e => e.Id == id);
            if (selectEmployee == null)
            {
                Console.WriteLine("Employee Not Found ...");
                return null;
            }
            return selectEmployee;
        }
    }
}

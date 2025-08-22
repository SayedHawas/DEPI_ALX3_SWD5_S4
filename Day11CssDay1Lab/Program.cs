namespace Day11CssDay1Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ----------- Day 11 Day 1 in CSS And EFCore Database First ------------ ");

            /*
             Day 11
                **********************************
                C# Connection with Database EF Core Database First                       Done 
                IEnumerable vs IQueryable (LINQ)
                Types Execution Of LINQ 
                *************************
                Deferred and Immediate Execution
                *Deferred  --- Connect Mode     (execute when Call data) Show update 
                *Immediate --- Disconnect Mode  (execute immediate) Do  not Show update
                Serializing and Deserializing Data
                CSS Day 1 session  1 ~ 1:30    HTML 5 + CSS 3
             */
            #region Session Part 1 EFCore Database First 
            Console.WriteLine("C# Connection with Database EF Core Database First ");
            //1) Create Project 
            //2) Add NnGet Package 

            using (EfcoreDatabaseFirstDbContext db = new EfcoreDatabaseFirstDbContext())
            {
                var departments = db.Departments.ToList();
                Console.WriteLine(" -------------- Departments List-------------------");
                foreach (var department in departments)
                {
                    Console.WriteLine($"Id {department.DepartmentId} , Name {department.Name} ");
                }
                var employees = db.Employees.ToList();
                Console.WriteLine(" -------------- Employees List-------------------");
                foreach (var employee in employees)
                {
                    Console.WriteLine($"Id {employee.EmployeeId} , Name {employee.Name} Job {employee.JobTitle}  Salary {employee.Salary:C}  Department Name {employee.Department.Name}");
                }

                Console.WriteLine(" -------------- First Or Default-------------------");
                //LINQ-TO-Entity
                //  Select * from Department where Name like '%a'EndsWith
                //  Select * from Department where Name like 'a%'StartsWith
                //  Select * from Department where Name like '%a%'Contains
                var SelectDepartement = db.Departments.FirstOrDefault(d => d.Name.Contains('s'));
                Console.WriteLine(SelectDepartement.Name);

                var departementlist = db.Departments.Where(d => d.Name.Contains('s'));
                Console.WriteLine(SelectDepartement.Name);

            }
            #endregion
            Console.ReadLine();
        }
    }
}

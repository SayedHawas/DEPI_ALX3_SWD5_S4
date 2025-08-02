namespace Day5Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Day 5 Demos ---------");
            //Push & Pull & Clone Github Repos  Done 
            #region Session Part 1 
            ////How to create Object From Class 
            //Person ahmed = new Person();
            //ahmed.Id = 1;
            //ahmed.Name = "ahmed";
            //ahmed.Age = 24;
            //ahmed.Address = "Alex";
            //Console.WriteLine(ahmed.SayHello());
            ////ahmed.ApplicationName; //Can Not access For Const  
            ////ahmed.numberOfInstance;  // Static Member can Not access From Object

            ////Call static From Class
            //Console.WriteLine(Person.NumberOfInstance);

            //Console.WriteLine(ahmed.SayHello());
            //Console.WriteLine(ahmed.SayHello("Hello"));
            //Console.WriteLine(ahmed.SayHello("Welcome", name: "Ahmed")); //Pass Parameter By Naming


            //Person P1 = new Person();
            //Console.WriteLine(Person.NumberOfInstance);
            //Person p2 = new Person();
            //Console.WriteLine(Person.NumberOfInstance);



            ////Create Object With Non -default CTOR
            //Person p3 = new Person(1, "Mohamed", 24, "Cairo");
            //Console.WriteLine(p3.Name);
            //Console.WriteLine(Person.NumberOfInstance);
            //p3.SayHello();

            ////Inilitzer
            //Person p4 = new Person() { Id = 2, Name = "yasser", Age = 25, Address = "tanta" };
            //Console.WriteLine(Person.NumberOfInstance);
            //Console.WriteLine(p4.Name);
            //// p4.ConnectionString = "An other Connection"; ReadOnly
            //Console.WriteLine(p4.ConnectionString);
            ////Call By Class 
            //Console.WriteLine(Person.ApplicationName);
            ////Person.ApplicationName = "My Appliaction"; 

            //Console.ReadLine();
            #endregion
            #region Session Part 2
            //Inheritance
            Console.WriteLine(" ------------ Employee ------------");
            Employee emp = new Employee();
            emp.Id = 1;
            emp.Name = "Ahmed As Employee";
            emp.Age = 25;
            emp.Address = "Cairo";
            emp.Salary = 15000;
            emp.EmployeeType = EmployeeType.FullTime;
            emp.Department = "Software";
            emp.Job = "Full stack Developer";

            Console.WriteLine(emp.SayHello());
            Console.WriteLine($"Info : \n{emp.SayInfo()}");
            Console.WriteLine($"the Income is : {emp.InCome()}");

            Console.WriteLine(" ------------ Employee 2 PartTime ------------");
            Employee emp2 = new Employee();
            emp2.Id = 2;
            emp2.Name = "Ali As Employee";
            emp2.Age = 25;
            emp2.Address = "Cairo";
            emp2.RateHoure = 100;
            emp2.NumberOfHours = 1000;
            emp2.EmployeeType = EmployeeType.PartTime;
            emp2.Department = "Software";
            emp2.Job = "Full stack Developer";

            Console.WriteLine(emp2.SayHello());
            Console.WriteLine($"Info : \n{emp2.SayInfo()}");
            Console.WriteLine($"the Income is : {emp2.InCome()}");
            Console.WriteLine(" ------------ Employee 2 PartTime ------------");
            Employee emp3 = new Employee();
            emp3.Id = 3;
            emp3.Name = "tamer As Employee";
            emp3.Age = 25;
            emp3.Address = "Cairo";
            emp3.CostProject = 20000;
            emp3.EmployeeType = EmployeeType.PerProject;
            emp3.Department = "Software";
            emp3.Job = "Full stack Developer";

            Console.WriteLine(emp3.SayHello());
            Console.WriteLine($"Info : \n{emp3.SayInfo()}");
            Console.WriteLine($"the Income is : {emp3.InCome()}");
            Console.WriteLine(" ------------ Manager ------------");
            Manager mang = new Manager();
            mang.Id = 2;
            mang.Name = "Yasser As Manager";
            mang.Age = 35;
            mang.Address = "alex";
            mang.Salary = 25000;
            mang.Department = "Software";
            mang.Job = "Software Manager";
            mang.Tasks = " Follow Up , Review Tasks Employees ";
            mang.Bouns = 5000;
            Manager.Project project = new Manager.Project();
            project.ProjectName = "C# Project ";
            project.StartDate = DateTime.Now;
            project.EndDate = DateTime.Now;
            Console.WriteLine(project.ShowDetails());

            Console.WriteLine(mang.SayHello());
            Console.WriteLine($"Info : \n{mang.SayInfo()}");
            Console.WriteLine($"the Income is : {mang.InCome()}");

            //Type Can Be DataType
            //Collection -->Array  , ListArray  , List<T> ,Dic <int, string>

            List<int> list = new List<int>(); //Struct
            List<Employee> Employees = new List<Employee>();
            Employees.Add(emp);


            #endregion
            #region Session Part 3
            //Use type(Enum , Struct)
            //Create Object From Struct 
            Point p = new Point();
            //p = null;
            p.X = 120;
            p.Y = 201;
            Console.WriteLine(p.PrintPoint());
            Console.ReadLine();
            //int x = null;
            //Record 


            //List Of Code Enum 

            #endregion
            //-----
            //OOP
            //    1 - Object Class           Done
            //    2 - Inheritance            Done
            //    3 - Polymorphism           Done
            //    4 - Encapsulation
            //    5 - Abstraction

            //Create Class                       Done
            //Class Members                      Done 
            //         Fields                    Done
            //         Methods                   Done
            //         Property Full             Done
            //         Property Auto             Done
            //         Create Object From Class  Done
            //Constructor --                     Done
            //     Method OverLoad               Done               
            //     Constructor OverLoad          Done
            //Readonly Vs Const                  Done
            //Static member                      Done                   
            //Inheritance OverView               Done
            //Inheritance                        Done
            //Polymorphism (OverLoad, Override + Inheritance)  Done 
            //Type Can Be DataType                             Done
            //Types Enum, Struct ( Value type )                Done
            //Use type(Enum , Struct)                          Done
            //Windows Form
            //--------






        }
    }
}

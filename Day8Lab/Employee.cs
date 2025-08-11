namespace Day8Lab
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
        public bool Attend { get; set; }
        public int Age { get; set; }

        public static List<Employee> ListEmployees = new List<Employee>() {
            new Employee { Id = 1, Name = "Retaj", Job = "Developer", Salary = 5000, Attend = true },
            new Employee { Id = 2, Name = "Mariam", Job = "Dr", Salary = 6000, Attend = true },
            new Employee { Id = 3, Name = "sayed", Job = "Developer", Salary = 3000, Attend = false },
            new Employee { Id = 4, Name = "osama", Job = "eng", Salary = 7000, Attend = true },
         };

        public static void Report(List<Employee> list, MyConditionHandler conditionHandler)
        {
            foreach (Employee emp in list)
            {
                //Hard code
                //if (emp.Salary > 4000)
                if (conditionHandler(emp))
                {
                    Console.WriteLine($"the Id {emp.Id} name {emp.Name} salary {emp.Salary} job {emp.Job} Attend {emp.Attend}");
                }

            }
        }

        public delegate bool MyConditionHandler(Employee emp);



        public Employee()
        {
            //FileStream fs = new FileStream("C:/ahmed.txt", FileMode.OpenOrCreate);
            //using (StreamReader sr = new StreamReader(fs))
            //{

            //   sr


            //}
            //sr
        }
        public Employee(int id, string name, int age)
        {

        }
        ~Employee()
        {

        }
    }
}

namespace Day5Lab
{
    public enum EmployeeType  // Base On Int
    {
        FullTime = 1,
        PartTime,
        FreeLace,
        PerProject
    }
    public class Employee : Person
    {
        //string day = DayOfWeek.Monday.ToString();
        // Fulltime , PartTime , FreeLance ,PerProject 
        //public enum EmployeeType  // Base On Int
        //{
        //    FullTime = 1,
        //    PartTime,
        //    FreeLace,
        //    PerProject
        //}
        public string Job { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
        public double NumberOfHours { get; set; }
        public double RateHoure { get; set; }
        public double CostProject { get; set; }
        //Polymorphism (Override + Inheritance)
        public override double InCome()
        {
            //return base.InCome() + Salary;
            return base.InCome() + CalSalary();
        }
        public override string SayInfo()
        {
            return $"{base.SayInfo()}\nJob : {Job}\nSalary : {Salary}\nDepartment : {Department}\nEmployee Type : {EmployeeType}";
        }
        public double CalSalary()
        {
            double newSalary = 0;
            switch (EmployeeType)
            {
                case EmployeeType.FullTime:
                    newSalary = Salary;
                    break;
                case EmployeeType.PartTime:
                    newSalary = RateHoure * NumberOfHours;
                    break;
                case EmployeeType.FreeLace:
                    newSalary = RateHoure * NumberOfHours;
                    break;
                case EmployeeType.PerProject:
                    newSalary = CostProject;
                    break;
            }
            return newSalary;
        }
    }
}

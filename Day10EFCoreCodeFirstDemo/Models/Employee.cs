namespace Day10EFCoreCodeFirstDemo.Models
{
    public class Employee //  Row Entry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }
        public string Job { get; set; }


        public override string ToString()
        {
            //return base.ToString();
            return $" Id : {Id} Name : {Name} Age : {Age}  Job : {Job}  Salary : {Salary:C}";
        }
    }
}

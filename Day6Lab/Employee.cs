namespace Day6Lab
{
    public class Employee : Human
    {
        public Employee()
        {

        }
        public override void Name() //Override --> 
        {
            base.Name();
            Console.WriteLine("My Name is Employee ... ");
        }
    }
}

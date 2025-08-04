namespace Day6Lab
{
    public class Developer : Employee
    {
        public Developer()
        {

        }
        // override 

        public new void Name()
        {
            base.Name();
            Console.WriteLine("My Name is Developer ... ");
        }
    }
}

namespace Day7Lab
{
    public abstract class Human : IPerson //0 abstraction  --> 100% abstraction
    {
        //Variable 
        //Fields
        private int x;
        //Property 
        public abstract string Name { get; set; }

        public void Add()
        {
            throw new NotImplementedException();
        }

        //Abstract Method 
        public abstract void GetName();
        //public void getInfo()
        //{
        //    Console.WriteLine("Welcome From Human");
        //}

        public abstract double Income();
    }
}

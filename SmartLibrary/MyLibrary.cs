namespace SmartLibrary
{
    //Access Modifier
    public class MyLibrary
    {
        //Object  : 
        private string PrivateValue { get; set; }
        public string publicValue { get; set; }
        protected string protectedValue { get; set; }
        internal string internalValue { get; set; }
        internal protected string internalprotectedValue { get; set; }
        private protected string privateprotectedValue { get; set; }
    }

    public class test
    {
        public test()
        {
            MyLibrary Ml = new MyLibrary();
            Console.WriteLine(Ml.publicValue);
            Console.WriteLine(Ml.internalValue);
            Console.WriteLine(Ml.internalprotectedValue);
        }
    }
    public class testInheri : MyLibrary
    {
        public testInheri()
        {
            Console.WriteLine(publicValue);
            Console.WriteLine(protectedValue); //:
            Console.WriteLine(internalprotectedValue); // namespace + :
            Console.WriteLine(internalValue);          //namespace
            Console.WriteLine(privateprotectedValue);  // :                                  //
        }

    }
}

namespace WebAPIDay20Lab
{
    // to create Delegate 
    // using Name space System.Delegate
    public delegate string MyDelegate(string text);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Delegate & Event .
            // Pointer For Function .
            // Type --> DataType (LINQ , Pred , Func ,Action).
            // Close , Closing  , Closed
            // Closing --> With Close 
            // Closed  --> End Close 

            MyString ms = new MyString();
            MyDelegate d1 = new MyDelegate(ms.CaseText);
            MyDelegate d2 = ms.StringLenght;


            Console.Write("Enter Your Name : ");
            string t = Console.ReadLine();
            Console.WriteLine(d1.Invoke(t));

            Console.WriteLine(d1(t));
            Console.WriteLine(d2(t));

            ms.MyEvent += Ms_MyEvent;

            Console.ReadLine();


            //List<Student> Students = new List<Student>();
            int x = 10;
            x += 5;
        }

        private static string Ms_MyEvent(string text)
        {
            return "Welcome " + text;
        }
    }

    class MyString
    {
        //Event 
        public event MyDelegate MyEvent;

        public string CaseText(string text)
        {
            if (text == text.ToUpper())
            {
                return ("String is Capitals");
            }
            else if (text == text.ToLower())
            {
                return ("String is Small");
            }
            else
            {
                return ("String is Mixed ");
            }
        }
        public string StringLenght(string text)
        {
            return string.Format("the length for text is : {0}", text.Length.ToString());
        }
    }



}

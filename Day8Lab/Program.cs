namespace Day8Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ------------ Day 8 Demos -------");

            /*
             LINQ Language Integrated Query
                Delegate
                Connection With Database (Ado.Net)   Over View 
                EF Core 
            LINQ Principles:-
                ------------------
                1)Implicit type (Var)
                2)Object Initializer.
                3)Collection Initializer.
                4)Dynamic Name.
                5)Anonymous Types.
                6)Generic type.
                7)Extension Methods.
                8)Delegate. 
                9)Linq To Object (Linq Query).
                10)Anonymous Delegate.
                11)Anonymous Method. 
                12)Linq Lambda Expression. 
                13)Bulid-in Delegate.
                *****************************
                14) IEnumerable vs IQueryable.
             */
            #region Session Part 1
            //LINQ
            int[] Numbers = new int[5] { 1, 22, 66, 77, 55 };
            var x = from n in Numbers
                    where n % 2 == 0
                    select n;
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------");
            var y = Numbers.Where(x => x % 2 == 1);
            foreach (var item in y)
            {
                Console.WriteLine(item);
            }
            List<int> numbers = new List<int>();
            //1)Implicit type(Var)

            //2)Object Initializer.
            Employee e = new Employee() { Id = 1, Name = "", Age = 25 };
            //e.Id = 1;
            //e.Name = "";
            //e.Age = 25;
            Employee e2 = new Employee { Id = 1, Name = "", Age = 25 };

            //3)Anonymous Object.
            new Employee();

            //4)Collection Initializer.
            //Type Can Be DataType
            List<Employee> list = new List<Employee>() {
            new Employee(){ Id=1, Name = "tamer", Age= 25},
            new Employee(){ Id=2, Name = "yasser", Age= 30},
            new Employee(){ Id=3, Name = "sayed", Age= 35},
            new Employee(){ Id=4, Name = "Mariem", Age= 45}
            };

            var xx = from c in list
                     where c.Age > 30
                     select c;
            foreach (var item in xx)
            {
                Console.WriteLine($" Id : {item.Id} Name {item.Name} ,Age {item.Age} ");
            }
            //5)Anonymous Types.

            var v = new { Id = 1, Name = "", Salary = 20000, Address = "Alex" };
            //v.Id = 5; Read Only 

            var tt = from c in list
                     where c.Age > 30
                     select new { c.Name, c.Id };

            foreach (var item in tt)
            {
                Console.WriteLine($" Id : {item.Id} Name {item.Name} ");
            }


            //6)Dynamic Name.
            var vv = (string)null;
            //int n = null;

            var b = 1.25;
            //b = "Ahmed";

            dynamic dd = "Ahmed";

            Console.WriteLine(dd.Length);

            dd = 1.25;
            // Console.WriteLine(dd.Length);



            dynamic myObject = new System.Dynamic.ExpandoObject();
            myObject.DynamicPropertyName = "Some Value"; // Adding a property with a dynamic name
            Console.WriteLine(myObject.DynamicPropertyName);

            //7)Generic type.


            //8)Extension Methods.
            //Static Class Type This
            String Str = new String(new char[] { 'a', 'h', 'm', 'e', 'd' });
            string str2 = "Ahmed";
            Console.WriteLine(str2.CutLetter());
            int xn = 100;
            short sh = 200;
            long l = 2000;

            Int32 II = new Int32();
            II = 200;

            //9)Delegate.


            Console.ReadLine();
            #endregion

        }


    }
    public static class MyString
    {
        public static string CutLetter(this string text)
        {
            return text[0].ToString();
        }
    }
}

namespace Day4Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- Day 4 -----------");

            #region Session Part 1
            //Task 
            //int number = 12;
            //for (int i = 1; i <= number; i++)
            //{
            //    for (int j = 1; j <= number - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write(" *");
            //    }
            //    Console.WriteLine("");
            //}
            //Console.ReadLine();
            #endregion
            #region Session Part 2
            //lession 3 :Handling Exceptions
            //Try -- Catch
            //Try -- catch --Finally
            //try
            //{
            //    //Code Exception  
            //}
            //catch
            //{
            //    //Message 
            //}
            //finally
            //{
            //    //Stop streaming  | Connection | Event Final
            //    //  try Done | Catch Done
            //}
            //int x1 = 10; int y1 = 0;
            //int z1 = x1 / y1;             //10/0
            //Console.WriteLine(x1);

            //try
            //{
            //    int x = 10; int y = 0;
            //    int z = x / y;             //10/0
            //    Console.WriteLine(x);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine(" Error  !!");

            //}
            //do
            //{
            //    Console.Clear();
            //    try
            //    {
            //        object obj = null;
            //        Console.Write("Enter Number 1 : ");
            //        int n1 = int.Parse(Console.ReadLine());
            //        //int n1 = (int)obj;
            //        Console.Write("Enter Number 2 : ");
            //        int n2 = int.Parse(Console.ReadLine());
            //        int divs = n1 / n2;
            //        Console.WriteLine(divs);
            //        Div(100, 0);

            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Must Enter Only Numbers ...");
            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine($"Must Enter Integer Number Between {int.MinValue} And {int.MaxValue}");
            //    }
            //    catch (DivideByZeroException)
            //    {
            //        Console.WriteLine("Can Not Div By Zero ... ");
            //    }
            //    catch (NullReferenceException)
            //    {
            //        Console.WriteLine("Can not Working With Null Value ....");
            //    }
            //    catch (Exception ex) //Default Switch Case  
            //    {
            //        Console.WriteLine(ex.Message);
            //        Console.WriteLine(ex.StackTrace);
            //        Console.WriteLine(ex.ToString());
            //        Console.WriteLine(ex.InnerException);
            //        Console.WriteLine(ex.TargetSite);
            //        Console.WriteLine("Please Call Support ....");
            //    }
            //    finally
            //    {
            //        Console.WriteLine("Finish application ....");
            //        Console.ReadLine();
            //    }
            //} while (true);

            //Raising(Throwing) Exceptions

            //try
            //{
            //    Div(100, 0);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    FullName("Sayed", "Hawas");
            //    FullName("        ", "Hawas");
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            //Lesson 5 :Monitoring Applications
            #endregion
            #region Session Part 3 OOP
            //1 - Object Class
            //2 - Inheritance
            //3 - Polymorphism
            //4 - Encapsulation
            //5 - Abstraction

            //How To Create Class 
            //How to Create Object : Class Object Base Class 
            Human ahmed = new Human();
            //ahmed.SetName( "Ahmed Ali ");       //Set 
            //Console.WriteLine(ahmed.GetName()); //Get 

            //ahmed.Name = "Ahmed Ali ";
            //Console.WriteLine(ahmed.Name);

            //// ahmed.Id = 100;
            //Console.WriteLine(ahmed.Id);

            //ahmed.Attend = "Attend @ 2:00 ";
            ////Console.WriteLine(ahmed.Attend);

            //ahmed.JobTitle = "Full stack Developer ";
            //Console.WriteLine(ahmed.JobTitle);

            //ahmed.Salary = 9000;
            //Console.WriteLine(ahmed.Salary);
            //Human Mohamed = new Human();



            #endregion
            #region Session Part 4 OOP 
            //Type Can Be DataType 
            //-------------------------
            //User Def Type 

            //Create Object 
            Employee Mostafa = new Employee();
            Mostafa.Id = 1;
            Mostafa.Name = "Mostafa";


            //Class Members
            // Fields
            // Methods
            // Property Full
            // Property Auto
            // Create Object From Class


            //Create Class For Full Employee Data 
            //Create 2 Object Pass Data 
            //Create Method To Print Data 
            #endregion
        }


        static int Div(int n1, int n2)
        {
            if (n2 == 0)
            {
                throw new Exception("Sayed Say Can Not Div By Zero");
            }
            return n1 / n2;
        }
        /// <summary>
        ///  Full Name From First name &  LastName 
        /// </summary>
        /// <param name="FirstName">string</param>
        /// <param name="LastName">string</param>
        /// <returns>Ful Name As String </returns>
        /// <exception cref="Exception"> Null First Name </exception>
        static string FullName(string FirstName, string LastName)
        {
            if (FirstName.Trim() == string.Empty)
            {
                throw new Exception("Sayed Say Can Not Enter Empty First Name ");
            }

            return FirstName + LastName;
        }
    }

    //Access Modifier (Inheri & Object)
    //Create Class (Normal Class)
    public class Human
    {
        //Fields 
        private int _Id = 32132125;
        private string _Name;
        private string _attend;
        private int _salary;

        public string JobTitle { get; set; }

        public int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (_salary < 10000)
                {
                    _salary = 2500 + value;
                }
                else
                {
                    _salary = value;
                }
            }
        }

        //Property 
        public string Name
        {
            get { return _Name; }  // return 
            set { _Name = value; } // Void 
        }
        //Read Only 
        public int Id
        {
            get { return _Id; }
        }
        //Set Only 
        public string Attend
        {
            set { _attend = value; }
        }
        //Methods 
        //public string GetName()
        //{
        //    return Name;
        //}
        //public void SetName(string yourname)
        //{
        //    Name = yourname;
        //}
    }
}

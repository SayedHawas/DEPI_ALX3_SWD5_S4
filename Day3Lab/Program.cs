namespace Day3Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C# 6 , 7 , 8 ,9 ,12
            Console.WriteLine("Hello, C# in Day 3 ");
            #region Task Day 2 
            //Start:
            //    char choice;
            //    do
            //    {
            //        Console.Clear();
            //        Console.Write("Enter First Number");
            //        //ouble firstNumber = Convert.ToDouble(Console.ReadLine());
            //        double firstNumber;
            //        Console.WriteLine(double.TryParse(Console.ReadLine(), out firstNumber));
            //        Console.WriteLine(firstNumber);
            //        Console.Write("Enter Second Number");
            //        double secondNumber;
            //        double.TryParse(Console.ReadLine(), out secondNumber);
            //        Console.Write("Enter Operator + , - , * , /");
            //        string operation = (Console.ReadLine().Trim());
            //        switch (operation)
            //        {
            //            case "+":
            //                Console.WriteLine($"The result of {firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            //                break;
            //            case "-":
            //                Console.WriteLine($"The result of {firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            //                break;
            //            case "*":
            //                Console.WriteLine($"The result of {firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            //                break;
            //            case "/":
            //                if (secondNumber == 0)
            //                {
            //                    Console.WriteLine("Division by zero is not allowed.");
            //                    // Restart the input process
            //                }
            //                Console.WriteLine($"The result of {firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
            //                break;
            //            default:
            //                Console.WriteLine("Invalid operator. Please enter +, -, *, or /.");
            //                break;
            //        }
            //        Console.WriteLine("Do you want to continue? (y/n)");
            //        choice = Console.ReadKey().KeyChar;
            //        //Console.WriteLine("Press any key to continue...");
            //        //
            //        //goto Start;
            //    } while (choice == 'y' || choice == 'Y');
            #endregion
            //Console.WriteLine("Finish Program ....");
            #region Session Part 1
            //double d = 10 / 3D;
            //Console.WriteLine($"The value of d is {Math.Round(d, 2)}");
            //-Implementing Iteration Logic
            // for , While , Do
            //Console.WriteLine("-------- For ++ -------------");
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("---------  For -- ------------");
            //for (int i = 10; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("------------------- For Nest IF ----------------------");
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i > 5)
            //    {
            //        break; // Exit the loop if i is less than 5  
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("--------------- Loop Skip -------------");
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        continue; // Skip the current iteration when i is 5
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("End Loop ");
            //Console.WriteLine("------------ Even Numbers ---------------");
            //for (int i = 0; i <= 10; i += 2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("------------ Even Numbers ---------------");
            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //for (int i = 1; i <= 12; i++)
            //{
            //    for (int l = i; l <= 12; l++)
            //    {
            //        Console.WriteLine($"{i} X {l} = {i * l}");
            //    }
            //    Console.WriteLine("----------------");
            //}

            //While
            //Console.WriteLine("------------  While ---------------");
            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine(++i);//(i++);
            //    //i++;
            //}
            //DO
            //Console.WriteLine("------------  Do ---------------");
            //int d = 0;
            //do
            //{
            //    Console.WriteLine("Welcome ... " + (++d));
            //} while (d < 10);

            #endregion
            #region Session Part 2
            ////Collection 
            //int x = 5;
            ////array 
            //int[] numbers = new int[3];
            ////Assign
            //numbers[0] = 600;
            //numbers[1] = 300;
            //numbers[2] = 100;

            ////numbers[3] = 400; // This will throw an IndexOutOfRangeException
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers.Length);
            //Array.Sort(numbers); //Arrage
            //Console.WriteLine("--------- For On Array --------");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //Console.WriteLine(" -------------- Foreach Array -----------");
            ////Foreach
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            // System --> Array 
            //declare Array 
            //int[] nums = new int[] { 15, 5, 24, 235, 85, 7, 5, 7, 41 }; //9 Count , Index 8 
            //Console.Write("Enter Number Of Books : ");
            //int numberOfBooks;
            //int.TryParse(Console.ReadLine(), out numberOfBooks);
            //string[] books = new string[numberOfBooks];
            //for (int i = 0; i < numberOfBooks; i++)
            //{
            //    Console.Write($"Enter Book Name {i + 1} : ");
            //    books[i] = Console.ReadLine();
            //}
            //Console.WriteLine("Press Any Key to Print Libaray ...");
            //Console.ReadLine();
            //Array.Sort(books); // Sort the books array
            //foreach (var item in books)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("----- Finish ------");
            //2D Array 
            //int[,] Matrix = new int[2, 3] //2 Row , 3 Column
            //{
            //    { 1, 2, 3 },
            //    { 4, 5, 6 }
            //};

            //for (int i = 0; i < Matrix.GetLength(0); i++) // GetLength(0) gives the number of rows
            //{
            //    for (int j = 0; j < Matrix.GetLength(1); j++) // GetLength(1) gives the number of columns
            //    {
            //        Console.Write(Matrix[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //-----------------------------------------------
            //List array  System --> Collection 
            //Object Boxing / Unboxing 
            //ArrayList arrlist = new ArrayList();
            //arrlist.Add(100); //0
            //arrlist.Add("Hello");
            //arrlist.Add(3.14);
            //arrlist.Add(true);
            //Console.WriteLine(arrlist.Count);
            //Console.WriteLine((int)arrlist[0] + 50);
            ////----------------------------------------------------
            ////List<int> listNumbers = new List<int>() { 1,25,2554,225,4};
            //List<int> listNumbers = new List<int>();
            //listNumbers.Add(25);
            //listNumbers.Add(255);
            //listNumbers.Add(125);
            //listNumbers.Add(225);
            //listNumbers.Add(725);

            //listNumbers.Remove(125);
            //listNumbers.RemoveAt(2);
            //listNumbers.RemoveRange(0, 1);
            //listNumbers.RemoveAll(e => e == 100);
            //listNumbers.RemoveRange(0, listNumbers.Count - 1);
            //Console.WriteLine("Count of List : " + listNumbers.Count);

            //for (int i = 0; i < listNumbers.Count; i++)
            //{
            //    Console.WriteLine(listNumbers[i]);
            //}
            //Console.WriteLine("---------------- List Sort --------------");
            //listNumbers.Sort(); // Sort the list
            //foreach (int number in listNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion
            #region Session Part 3  
            //List<string> names = new List<string>();
            //names.Add("Ahmed");//0
            //names.Add("Ali");  //1
            //names.Add("Ali");  //2

            //Dictionary<int, string> students = new Dictionary<int, string>();
            //students.Add(1, "Ahmed");
            //students.Add(2, "Ali");
            //students.Add(3, "Sara");
            //students.Add(4, "Hassan");
            //students.Add(5, "Fatima");
            //students.Add(6, "Ali");

            //Console.WriteLine("Count of Students : " + students.Count);
            //Console.WriteLine("Key 1 : " + students[1]);
            //Console.WriteLine("Key 2 : " + students[2]);
            //Console.WriteLine("Key 3 : " + students[3]);
            //Console.WriteLine("Key 4 : " + students[4]);
            //Console.WriteLine("Key 5 : " + students[5]);
            //Console.WriteLine("Key 6 : " + students[6]);
            //foreach (var item in students)
            //{
            //    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            //}
            #endregion
            #region Session Part 4 
            //1 - What Is a Method ?                                          Done 
            //2 - Types Of Methods(void | Return Datatype)                    Done 
            //3 - Creating a Method                                           Done 
            //4 - Calling a Method                                            Done
            //5 - Method With Paramenters   Optional Paramters Defualt value  Done 
            //6 - Pass Paramenters With Value & Ref & Out                     Done
            //7 - Using Parameter Arrays                                      Done
            //8 - Key Words Params                                            Done
            //9 - Overloaded Methods                                          Done

            //calling a Method
            //Print();
            //Print("Hello World");
            //Console.WriteLine();
            //Console.WriteLine("Welcome");
            //Console.ReadLine();
            //Console.WriteLine(getName());
            //getName("Sayed", "Hawas");
            //string str = Calc(10, 5, "+");
            //Console.WriteLine(str);

            //int x;
            //x = 10 + 5;
            //Console.WriteLine(x);
            //Console.WriteLine(sum(10, 20, 30)); //Calling Method with 3 parameters
            //Console.WriteLine(sum(num2: 20, num1: 30, num3: 50)); ; //Calling By Naming 
            //Console.WriteLine(sum(100, 20)); //Calling Method with 2 parameters
            //Console.WriteLine(sum(50));

            //Add(100);
            //Add(y:100,x:500);

            // Pass Parameters For Methods
            // 1) Pass by Value
            // 2) Pass by reference
            // 3) Pass by Out
            int number = 5;
            Console.WriteLine(number);
            Console.WriteLine(AddValue(number));
            Console.WriteLine(number);
            Console.WriteLine("----------- Reference----------- ");
            int numberRef = 10;
            Console.WriteLine(numberRef);
            Console.WriteLine(AddRefere(ref numberRef));
            Console.WriteLine(numberRef);
            Console.WriteLine("----------- Out ----------- ");
            int numberOut;
            Console.WriteLine(IsNumberOdd(10, out numberOut));  //false  0
            //Console.WriteLine(numberOut);
            IsNumberOdd(7, out numberOut); //true   7

            //
            Console.WriteLine("--------- Array As Parameters ---------");
            int[] x = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(SumArray(x));

            Console.WriteLine(SumArray(125, 258, 225, 5, 55, 99));
            #endregion
            //Task 
            //Create Appliaction To Calc + , - , * , /
            //With Methods 
            //Number Odd / Even 
            //Create Method To get the Primary Number From Range 
            //Task *
        }
        static bool IsNumberOdd(int number, out int result)
        {
            if (number % 2 != 0)
            {
                result = number;
                return true;
            }
            result = 0;
            return false;
        }
        static int AddValue(int x)
        {
            return x += 10;
        }
        static int AddRefere(ref int x)
        {
            return x += 10;
        }

        static double Add(double x, double y = 20)
        {
            return x + y;
        }
        static double sum(double num1 = 10, double num2 = 20, double num3 = 10)
        {
            return num1 + num2 + num3;
        }
        //Create Method (Void , Return type ) Parameters
        //Create Method Void 
        static void Print()//Without parameters Arguments
        {
            Console.WriteLine("Hello From Print Method");
        }
        static void Print(string str)//With parameters Arguments OverLoad
        {
            Console.WriteLine($"Method Say {str} ");
        }
        static string getName()
        {
            return "Ahmed Ali ";
            //Console.WriteLine("This line will not be executed because the return statement above exits the method early.");
        }
        static string getName(string firatname, string lastname)
        {
            return $"{firatname} {lastname}";

        }
        static string Calc(double number1, double number2, string opration)
        {
            //int num1=0;
            //Console.WriteLine(num1);
            string result = string.Empty;
            //Console.WriteLine(result);
            //int.TryParse(number1.ToString(), out num1);
            switch (opration)
            {
                case "+":
                    result = $"The result of {number1} + {number2} = {number1 + number2}";
                    break;
                case "-":
                    result = $"The result of {number1} - {number2} = {number1 - number2}";
                    break;
                case "*":
                    result = $"The result of {number1} * {number2} = {number1 * number2}";
                    break;
                case "/":
                    if (number2 == 0)
                    {
                        result = "Division by zero is not allowed.";
                        // Restart the input process
                    }
                    result = $"The result of {number1} / {number2} = {number1 / number2}";
                    break;
                default:
                    result = "Invalid operator. Please enter +, -, *, or /.";
                    break;
            }
            return result;
        }

        /// <summary>
        /// Sum of an array of integers.
        /// </summary>
        /// <param name="numbers"> Array Of Integer </param>
        /// <returns> Integer</returns>
        static int SumArray(params int[] numbers)
        {
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            return total;
        }
    }
}
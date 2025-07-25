namespace Day2Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Session Part 1
            // What are Data Types?
            /*
             * byte , sbyte , short , int , long
             * float , double , decimal 
             * string 
             * char
             * bool
             * Date time
             * object 
             * var 
             * Dynamic
             */
            Console.WriteLine("Lab ...");
            // Enter First Number 
            Console.Write("Enter First Number : ");
            //int number1 = int.Parse(Console.ReadLine());
            //// Entry Second Number
            //Console.Write("Enter Seoncd Number : ");
            //int number2 = int.Parse(Console.ReadLine());
            ////Operator + Concat 
            //Console.WriteLine(number1 + " + " + number2 + " = " + (number1 + number2));
            //Console.WriteLine(number1 + " - " + number2 + " = " + (number1 - number2));
            //Console.WriteLine(number1 + " X " + number2 + " = " + (number1 * number2));
            //Console.WriteLine(number1 + " / " + number2 + " = " + (number1 / number2));
            ////String Format
            //Console.WriteLine("{0} + {1} = {2}", number1, number2, (number1 + number2));
            //Console.WriteLine($"{number1} + {number2} = {(number1 + number2)}");

            ////implicit  Small --> Big 
            ////byte , sbyte , short , int , long
            //byte b = 255;
            //Console.WriteLine(b);
            //int i = 6565454;
            //Console.WriteLine(i);
            //long l = 6545464644654;
            ////Assign  =       ( Left Hand = Right Hand )
            //l = i; //implicit
            //i = (int)l;
            ////Explicit    Big --> Small (Cast)

            ////float , double , decimal

            //float f = 1 / 3F;
            //Console.WriteLine(f);
            //double d = 1 / 3D;
            //Console.WriteLine(d);
            //decimal M = 1 / 3M;
            //Console.WriteLine(M);

            //M = (decimal)f;
            #endregion
            #region Session Part 2
            ///*string
            //* char
            //* bool
            //* Date time
            //* object
            //* var
            //* Dynamic */
            //// =
            //char a = 'a';
            //Console.WriteLine(a);
            //char A = (char)65;
            //Console.WriteLine(A);
            //bool YesOrNo = true;
            //YesOrNo = 1 > 5;  // > , < , >= , <= , == , !=
            //Console.WriteLine(YesOrNo);
            //DateTime dt = new DateTime();
            //dt = DateTime.Now;
            //Console.WriteLine(dt);

            ////int , Long , Decimal , Bool -- > Not assign With Null
            ////string Allow Null

            ////Box
            ////Boxing
            //object obj = 125;
            //obj = "Ahmed";
            //obj = 'a';
            //obj = 1.25m;
            //obj = 1.2587f;
            //obj = DateTime.Now;
            //obj = true;
            //obj = 150;

            ////Unboxing
            //int x = (int)obj + 10;
            //Console.WriteLine(x);

            //obj = "Ahmed";
            //string str3 = (string)obj;
            //obj = 'a';
            //char aa = (char)obj;
            ////-----------------------------
            ////Database 
            //DateTime dt2 = DateTime.Now;
            ////Object
            //object ob = dt2;
            //int year = ((DateTime)ob).Year;
            ////Var
            //var vt = dt2;
            //year = vt.Year;
            ////---------------------------
            //// = , += , -= , *= ,/=
            //// ++ , --
            //int num = 5;
            //num = num + 3;
            //Console.WriteLine(num);
            //num += 10;
            //Console.WriteLine(num);
            //num -= 5;
            //Console.WriteLine(num);
            //num += 1;
            //num++;
            //Console.WriteLine("---------------------");
            //int m = 5;
            //Console.WriteLine(m);
            ////++m; PerFix 
            //Console.WriteLine(++m);
            ////m++; PostFix
            //Console.WriteLine(m++);
            //Console.WriteLine(m);

            ////Dynamic
            //dynamic dy = "Ahmed";
            ////dy +=  " Ali";
            //dy += " Ali";
            //dy = 1000;
            //int total = dy + 10;
            //Console.WriteLine(total);

            ////Compling Error 
            ////var vb = null;
            ////var vbb = 150;
            ////vbb = 1.2;

            ////Runtime Error 
            //string str4 = "Welcome in C#";
            //Console.WriteLine(str4.Length);


            //dynamic str5 = "Welcome in C#";
            //Console.WriteLine(str4.Length);

            ////dynamic c1 = 150;
            ////Console.WriteLine(c1.Length); // Error Runtime 

            #endregion
            #region Session Part 3
            //*)const:-
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            //System.Math

            //Jump statments
            //Start:
            //    Console.Clear();
            //    Console.Write("Enter Number 1 : ");
            //    int x = int.Parse(Console.ReadLine());

            //    Console.Write("Enter Number 2 : ");
            //    int y = int.Parse(Console.ReadLine());

            //    Console.WriteLine($"{x} + {y} = {(x + y)}");
            //    Console.WriteLine("Press any Key ....");
            //    Console.ReadLine();
            //    goto Start;



            // *)Literals Letters:-
            //-----------------------

            //Console.WriteLine("Sayed hawas");
            //Console.WriteLine("Sayed       Hawas");
            //Console.WriteLine("Sayed\t hawas");
            //Console.WriteLine("----------------");
            //Console.WriteLine("Sayed\n hawas");
            //Console.WriteLine("Welcome in \"C#\" ");
            //Console.WriteLine("Sayed \"Said\" Hawas");
            //Console.WriteLine("c:\\folder\\ahmed.doc");
            //Console.WriteLine(@"c\folder\ahmed.doc");
            //Console.WriteLine("\a"); // beep 
            //Console.WriteLine("\0"); // Null





            #endregion
            #region Session Part 3 (Implementing Conditional Logic)
            //Implementing Conditional Logic
            // ? :  , IF , Switch
            //int x = 5;
            //int y = 10;

            //Console.WriteLine(x > y ? "X Gt Y" : "Y Gt X");

            //if (x > y)
            //{
            //    Console.WriteLine("X Gt Y");
            //}
            //else
            //{
            //    Console.WriteLine("Y Gt X");
            //}
            //x = 10;
            //y = 10;
            ////-------------------
            //if (x > y)
            //{
            //    Console.WriteLine("X Gt Y");
            //}
            //else if (y > x)
            //{
            //    Console.WriteLine("Y Gt X");
            //}
            //else
            //{
            //    Console.WriteLine("Y = X");
            //}

            //if (x == y)
            //{
            //    Console.WriteLine("x= y");
            //    Console.WriteLine("x equal y");
            //}
            ////Logical Operator  && ||
            //if (1 < 10 || 1 > 0 || 5 > 4 || 6 > 3)
            //{
            //    Console.WriteLine("True");
            //}

            //if (1 > 10 && 1 > 0 && 5 > 4 && 6 > 3)
            //{
            //    Console.WriteLine("True");
            //}

            ////Nested
            //Console.Write("Enter Username ");
            //string username = Console.ReadLine();
            //Console.Write("Enter Password ");
            //string password = Console.ReadLine();
            //if ((username == "ahmed" && password == "123") || (username == "sayed" && password == "222") || (username == "retaj" && password == "333"))
            //{
            //    Console.WriteLine(username + ": " + "Welcome in My application ");
            //    if (username == "sayed" || username == "retaj")
            //        Console.WriteLine("Welcome Admin");
            //    else
            //        Console.WriteLine("Welcome Client");
            //}
            //else
            //{
            //    Console.WriteLine("Username Or Password are invalid ....");
            //}

            //int x = 150;
            //if (x < 100)
            //{
            //    Console.WriteLine("x<100");
            //}
            //else if (x < 200)
            //{
            //    Console.WriteLine("x<200");
            //}
            //else if (x < 500)
            //{
            //    Console.WriteLine("x<500");
            //}
            //else if (x < 1000)
            //{
            //    Console.WriteLine("x<1000");
            //}
            //else
            //{
            //    Console.WriteLine("x>1000");
            //}


            //int y = 1000;
            //switch (y)
            //{
            //    case 100:
            //        Console.WriteLine("100");
            //        break;
            //    case 200:
            //        Console.WriteLine("200");
            //        break;
            //    case 500:
            //        Console.WriteLine("500");
            //        break;
            //    case 1000:
            //        Console.WriteLine("1000");
            //        break;
            //    default:
            //        Console.WriteLine("GT 1000");
            //        break;
            //}


            Console.Write("plz enter num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("plz enter num2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("plz enter operator");
            char op = char.Parse(Console.ReadLine());
            switch (op)
            {
                case '+':
                    Console.WriteLine(num1 + num2);
                    break;
                case '-':
                    Console.WriteLine(num1 - num2);
                    break;
                case '*':
                    Console.WriteLine(num1 * num2);
                    break;
                case '/':
                    Console.WriteLine(num1 / num2);
                    break;
                default:
                    Console.WriteLine("invalid operator");
                    break;
            }
            #endregion
        }
    }
}

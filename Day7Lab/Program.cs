namespace Day7Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" --------------- Day 7 Demos -----------");
            /*
                - Generic type.
                   https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/generics
                   generics provide type safety, flexibility, and reusability.
                
            Generic type.      Class <T> ,Interface <T>       Done 
            -------------- Into Generic Type ---------------------
            Generic Method     Return T                       Done    
            Generic Property   Getter , Setter T              Done               
            Generic Parameter  Parameter T                    Done 
            ------------------------------------------------------
                - Abstraction                                 Done
            Person  - Abstract Class                          Done
                    - Interface                               Done
                    - IEmployee,IPathen,IDoctor 
                    - Generic Interface                       Done
                    - Contract Method                         Done
                    - CRUD  Create , Read (All , ByID) , Update , Delete   Done

                - IO Library  Input & Output  Drive , Folder , File ,     Done
                - Streaming (File ,Memory, Read , Write )                 Done
                - Binary Reader , Binary Writer                           Done
                - DriveInfo, Directory , DirectoryInfo ,File ,FileInfo    Done 
             
             */
            #region Session Part 1
            //Type Can Be DataType

            //int[] x = new int[3] { 1, 2, 30 };  //Array 
            //x[0] = 200;

            //ArrayList Al = new ArrayList();  // Object Base 
            //Al.Add(100);      //Boxing
            //Al.Add("Sayed");
            //int y = (int)Al[0]; //UnBoxing

            //List<int> a = new List<int>(); //Generic List    List<string>  
            //a.Add(100);
            ////a.Add("ahmed");
            //int t = a[0];

            //// Non- Generic 
            //Console.WriteLine("    ---  Non- Generic   --   ");
            //IntMyList Numbers = new IntMyList(3);
            //Numbers.Add(100);
            //Numbers.Add(200);
            //Numbers.Add(300);
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers.GetValue(i));
            //}

            ////IntMyList doubleNumber = new IntMyList(3);
            ////doubleNumber.Add(100.5);
            //Console.WriteLine("    ---  Generic <INT>  ---   ");
            //GenericMyList<int> Nums = new GenericMyList<int>(3);  //Value Type Struc
            //Nums.Add(100);
            //Nums.Add(200);
            //Nums.Add(300);
            //for (int i = 0; i < Nums.Length; i++)
            //{
            //    Console.WriteLine(Nums.GetValue(i));
            //}

            //Console.WriteLine("    ---  Generic <String>  ---   ");
            //GenericMyList<string> Names = new GenericMyList<string>(3);
            //Names.Add("tammer");
            //Names.Add("Ali");
            //Names.Add("Mariem");
            //for (int i = 0; i < Names.Length; i++)
            //{
            //    Console.WriteLine(Names.GetValue(i));
            //}




            #endregion
            #region Session Part 2 
            //- Abstraction             Done 
            //- Abstract Class          Done 
            //- Interface               Done
            //- Generic Interface       Done
            //base Of Object 
            // Human H = new Human();  Error  // Employee , Manager , Client , suppler

            Human ahmed = new Employee();
            ahmed.Name = "Ahmed Ali ";
            ahmed.GetName();


            Human yasser = new Manager();
            yasser.Name = "yasser Mohamed ";
            yasser.GetName();

            #endregion

            Console.ReadLine();
        }
    }
    //Non Generic 
    public class IntMyList
    {
        private int[] mylist;
        private int CurrentIndex = 0;

        public int Length { get; }
        public IntMyList(int length)
        {
            mylist = new int[length];
            Length = length;
        }

        public void Add(int value)
        {
            mylist[CurrentIndex++] = value;
            //CurrentIndex++;
        }

        public int GetValue(int index)
        {
            return mylist[index];
        }
    }
    //Generic Type 
    public class GenericMyList<T>  //where T:Person  //where T:struct   //Class Type Referance, Struct  Value Type 
    {
        private T[] mylist;  //Variable Generic 
        private int CurrentIndex = 0;


        public T Values { get; set; }  //Property Generic
        public int Length { get; }
        //CTOR
        public GenericMyList(int length)
        {
            mylist = new T[length];
            Length = length;
        }

        public void Add(T value) //Generic Parameter
        {
            mylist[CurrentIndex++] = value;
            //CurrentIndex++;
        }
        //Generic Method
        public T GetValue(int index)
        {
            return mylist[index];
        }
    }
    //public class Person
    //{

    //}
}

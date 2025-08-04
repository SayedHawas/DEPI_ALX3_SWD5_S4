using SmartLibrary;
namespace Day6Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------- Day 6 Demos ----------------");

            /*
                1 - Object Class                                          Done
                2 - Inheritance                                           Done
                3 - Polymorphism  Overload - Override                     Done
                             Method overriding  virtual ,override ,new    Done
                4 - Encapsulation  DLL  hide Data 
                5 - Class Types                                           Done
                     Types Of Class  (Referenace Type)                    Done
                            Normal Class                                  Done                                     
                            Sealed Class                                  Done                                       
                            static Class                                  Done                         
                            Partial Class                                 Done                                      
                            Abstract Class                                Done             
                            [Inner]Internal Class}                        Done
                            Recursion Method                              Done
                            Static Class in Business                      Done

                Class Library  (DLL)                                      Done

                6 - Access Modifiers                                      Done
                Encapsulation (DLL)  Hide Data                            Done                                              
                Encapsulation -->  Property (Full , Auto)  & DLL (Access Modifier)  Class Library {private - Public ...}  Done 
                --------------------------------------------------------------
                Access Modifiers                                           Done                        
                -----------------
                https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers

	                (public ,private ,protected,internal,protected internal, private protected ,file)
	
	                public: Code in any assembly can access this type or member. The accessibility level of the containing type controls the accessibility level of public members of the type.
	                private: Only code declared in the same class or struct can access this member.
	                protected: Only code in the same class or in a derived class can access this type or member.
	                internal: Only code in the same assembly can access this type or member.
	                protected internal: Only code in the same assembly or in a derived class in another assembly can access this type or member.
	                private protected: Only code in the same assembly and in the same class or a derived class can access the type or member.
	                file: Only code in the same file can access the type or member.
               
              Extension Method                                                Done
            -----------------------------------------------------------------------------------------------------------------------------------------------
            * Generic type.
            8 - IO Library
       
            7 - Abstraction
                      - Abstract Class   0 To 100%    method , Abstract Method
                      - Interface     100%  
               
                9 - Connection database (LINQ)
                10- Delegate & Event

                HTML 3 Session  1hour C# Advance  1.5  
                CSS  3 Session  1hour C# Advance  1.5 
            
            */
            #region Session Part 1 
            //Human h = new Human();
            //Console.WriteLine("---Human---");
            //h.Name();
            //Employee Em = new Employee();
            //Console.WriteLine("---Employee---");
            //Em.Name();
            //Console.WriteLine("--- Developer ---");
            //Developer Dv = new Developer();
            //Dv.Name();

            //User Def Types 
            //1) Class       Ref
            //2) Struct      Value
            //3) Enum        value

            //Type Can be DataType

            // Each Class Types With Object & Inhertince
            //Console.WriteLine(" ------- Normal Class --------- ");
            //1) Normal Class  (Non Static Class) Object , Inhert To  , Inhert From
            //Can create Static & Non-static Member
            //NormalClass Nc = new NormalClass();
            //Nc.TestMethod();

            //Console.WriteLine(" ------- Sealed Class --------- ");
            //2) Sealed Class  Object , Inhert To  
            SealedClass Sc = new SealedClass();
            //Sc.TestMethod();
            //Sc.TestInInhertince();


            //3) static Class  (Helper , Tools ...)  Can not user by Object 
            // StaticClass Stc = new StaticClass();
            //How To user Static Type 
            //StaticClass.Clean();
            //Can not Inhert To 
            //Can Not Inhert From 


            //4) Partial Class    Object , Inhert To  , Inhert From 
            //Generated Code --
            //Team Class 
            PartialClass Pc = new PartialClass();
            //Pc.Name = "test";
            //Pc.Id = 1;
            //Pc.Create();



            //5) Abstract Class  Can Not Create Object 
            // AbstractClass Ac = new AbstractClass();
            //Inherit From   & to 
            //Implementing 

            //virtual ,override ,Abstract

            //virtual Normal Class  (Implementing)
            //Abstract Into Abstract Class

            //Override  --> virtual base  
            //Override  --> Abstract No base   

            //6)[Inner]Internal Class}
            //OuterClass O = new OuterClass();
            //OuterClass.InnerClass I = new OuterClass.InnerClass();
            //I.Add();



            #endregion
            #region Session Part2
            //How to Open IL Disassembly in VS
            //-------------------------------- -
            //Open this path C:\Program Files(x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6.2 Tools
            //Open File ilasm.exe
            //Drag and Drop(exe Or dll) File to show the IL Dasm Code For it

            //Recursion Method
            //Console.WriteLine(Factorial(6));
            //Console.WriteLine(FactorialRecursion(6));

            //Hide Data 
            // using DLL 
            //MyLibrary ml = new MyLibrary();
            //Console.WriteLine(ml.publicValue);
            //Console.ReadLine();
            #endregion
            #region Session Part 3 
            //Extension Method          //SOILD 
            //OPEN Extension & Close Modification
            int x = 10;
            Console.WriteLine(x.Add(20));

            #endregion
        }



        public static int Factorial(int Number)
        {
            int Result = Number;
            for (int i = Number - 1; i >= 1; i--)
            {
                Result *= i;
            }
            return Result;
        }
        //Recursion Method 
        public static int FactorialRecursion(int Number)
        {
            if (Number == 0)
            {
                return 1;
            }
            return Number * FactorialRecursion(Number - 1);
        }
    }

    public static class MyInt
    {
        static MyInt()
        {

        }
        public static int Add(this int x, int y)
        {
            return x + y;
        }
    }
    public class testMyLibrary : MyLibrary
    {
        public testMyLibrary()
        {

            Console.WriteLine(publicValue);
            Console.WriteLine(protectedValue);
            Console.WriteLine(internalprotectedValue);

        }
    }
    public class InhertinaceTest
    {
        public string TestInInhertince()
        {
            return "String for test ....";
        }
    }
    public class NormalClass : InhertinaceTest
    {
        public string TestMethod()
        {
            return "String for test ....";
        }
        public virtual void testOverRide()
        {
            Console.WriteLine();
        }
    }
    public class DrivenClass : NormalClass // : PartialClass  //:StaticClass  //: SealedClass //NormalClass
    {
        public override void testOverRide()
        {
            base.testOverRide();
        }
    }
    public sealed class SealedClass : InhertinaceTest
    {
        public string TestMethod()
        {
            return "String for test ....";
        }
    }
    public static class StaticClass //:InhertinaceTest
    {
        //CTOR
        static StaticClass()
        {
            Console.WriteLine("Print From static CTOR...");
        }
        //Can Not create Non-static member into Static Type 
        public static void Clean()
        {
            Console.WriteLine(" Clean all Input ....");
        }
    }
    public partial class PartialClass : InhertinaceTest
    {
        public string Name { get; set; }
        public void Create()
        {

        }
    }
    public abstract class AbstractClass
    {
        //Abstract Member Method Head Without body 
        //when Inheritance From it Must Create Body 

        public void Add()
        {

        }
        public abstract void Create();
    }
    public class TestInhertFromAbstract : AbstractClass
    {
        public override void Create()
        {
            throw new NotImplementedException();
        }
    }
    public interface ITestInterface
    {
        void Add();
        void Edit();
        void Remove();
        //public void RemoveAll()
        //{ 

        //}
    }
    public class UsingInterface : ITestInterface
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }
    }
    public abstract class test : AbstractClass
    {
        public abstract void Update();
    }
    public class TestTwo : test
    {
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
    public class OuterClass
    {
        public int Id { get; set; }
        private string str;

        //public OuterClass()
        //{
        //    InnerClass Ic = new InnerClass();

        //}

        public class InnerClass : test
        {
            private string Innerstr;
            public InnerClass()
            {
                //OuterClass Oc = new OuterClass();
                //string x = Oc.str;
            }

            public override void Create()
            {
                throw new NotImplementedException();
            }

            public override void Update()
            {
                throw new NotImplementedException();
            }
        }
    }
}

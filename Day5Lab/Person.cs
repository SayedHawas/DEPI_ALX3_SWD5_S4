namespace Day5Lab
{
    /// <summary>
    ///  Person as Human
    /// </summary>
    public class Person
    {
        //Class Members
        //Static Member
        public static int NumberOfInstance = 0;  //Class 
        //Access Modifier (Private , public)
        //Readonly Vs Const
        //Const Can Not access From Object 
        public const string ApplicationName = "Smart Application";  //Work As static 

        public readonly string ConnectionString;
        //Fields
        private int _id;
        private string _name;
        private int _age;

        //Constructor --
        //1- Public
        //2- Without Return type (Void - datatype(int , string ....))
        //3- the same name Of Class
        //4- Without Parameter Default CTRO 
        //default Ctor Compiler 
        public Person()
        {
            NumberOfInstance += 1;
            Console.WriteLine("Create Object From Class Person ...");
            ConnectionString = "Connection SQL Server Data ";
        }
        //Constructor OverLoad
        //Non-Default With Parameters 
        public Person(int id, string name, int age, string address)
        {
            NumberOfInstance += 1;
            this._id = id;
            this._name = name;
            this._age = age;
            this.Address = address;
            ConnectionString = "Connection SQL Server Data ";
        }
        //Property Full OLD
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        //Property New 
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public int Age
        {
            set => _age = value;  //setter 
            get => _age;          //Getter
        }
        //Property Auto
        public string Address { get; set; }
        //Methods
        public string SayHello()
        {
            return "Welcome ...";
        }
        //Create Object From Class

        // Polymorphism (OverLoad)
        // Method Head + Body 
        //head Access Modifier  Return Type  Name (Params)
        //body {    Code   }
        //Method OverLoad
        public string SayHello(string msg)
        {
            return $"{msg} ...";
        }
        public string SayHello(string msg, string name)
        {
            return $"from {name}  say {msg} ....";
        }
        public string SayHello(int msg, string name)
        {
            return $"from {name}  say {msg} ....";
        }

        //Polymorphism (OverLoad, Override + Inheritance)
        //Overload Change Head 
        //Override Change Body
        public virtual double InCome()
        {
            return 0;
        }
        public virtual string SayInfo()
        {
            return $"ID : {_id}\nName : {_name}\nAddress : {Address}\nAge : {_age}";
        }

        //Struct 
        //Enum 
        //Delegate 
        //Event
        //Inner Class
        //Struct   Value type 
        //Enum     List Of Code 

    }
}

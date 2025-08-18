namespace Day10EFAndHtmlDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------  Day 10 In C# -----------");
            // Indexer

            #region Session Part1 
            //Array Fix Length
            int[] numbers = new int[7];// { 1, 0, 55, 88, 775, 23, 56, 514 };
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;
            numbers[5] = 6;
            numbers[6] = 7;

            //Dynamic Length     
            List<int> Numbs = new List<int>();
            Numbs.Add(50); //0
            Numbs.Add(2000); //1

            Console.WriteLine(Numbs[0]);

            SampleCollection<int> collection = new SampleCollection<int>();
            collection[0] = 100;  // 0  Like Array 
            collection[1] = 200;  // 1
            collection.Add(400);  // 2  Like List


            Console.WriteLine(collection[0]);
            Console.WriteLine(collection[2]);

            Console.WriteLine(numbers[0]); //Element Index 0 

            Console.WriteLine("--------------- Generic Type With Indexer ------------");
            SampleCollection<Employee> Employees = new SampleCollection<Employee>();
            Employees.Add(new Employee { Id = 1, Name = "Ahmed" }); //0
            Employees[1] = new Employee { Id = 2, Name = "Tamer" }; //1
            Console.WriteLine($" Counter : {Employees.Count}");
            for (int i = 0; i < Employees.Count; i++)
            {
                Console.WriteLine(Employees[i].ToString());
            }
            #endregion
            Console.ReadLine();
        }
    }

    public class SampleCollection<T>
    {
        private T _Id;
        // Declare an array to store the collection elements
        private List<T> data = new List<T>();

        // Define an indexer to allow array-like access
        public T this[int index]
        {
            get
            {
                // The get accessor returns the value at the specified index
                return data[index];
            }
            set
            {
                // The set accessor assigns a value to the element at the specified index
                if (index < data.Count)
                {
                    data[index] = value;
                }
                else
                {
                    data.Add(value);
                }
            }
        }

        //Property 
        public T ID
        {
            get { return _Id; } //Getter 
            set { _Id = value; } //Setter
        }
        //ReadOnly 
        public int Count
        {
            get
            {
                return data.Count;
            }
        }
        //Method 
        public void Add(T item)
        {
            data.Add(item);
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            //return base.ToString();
            return $"Id {Id} , Name {Name}";
        }
    }
}

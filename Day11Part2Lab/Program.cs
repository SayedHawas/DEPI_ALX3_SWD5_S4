namespace Day11Part2Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            LinqdbContext db = new LinqdbContext();
            //Take(3) --> Top 3
            IEnumerable<Student> Stu = db.Students.Where(q => q.Subject == "C#").ToList().Take(3);

            Console.WriteLine("------------ IEnumerable -------------");
            foreach (Student s in Stu)
            {
                Console.WriteLine($" the Name {s.Name} {s.Mark}");
            }
            Console.WriteLine("------------ IQueryable -------------");
            //Error
            //IQueryable<Student> Stu2 = db.Students.Where(q => q.Subject == "C#").ToList().Take(3);
            IQueryable<Student> Stu2 = db.Students.Where(q => q.Subject == "C#").Take(3);
            foreach (Student s in Stu2)
            {
                Console.WriteLine($" the Name {s.Name} {s.Mark}");
            }
            Console.ReadLine();
        }
    }
}

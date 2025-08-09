
namespace Day7Lab
{
    public class Employee : Human, IPerson, IOperation<Employee>, IDbConnection
    {
        private string _name;
        public override string Name { get => _name; set => _name = value; }

        public void CloseConnection()
        {
            throw new NotImplementedException();
        }

        public void Create(Employee Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override void GetName()
        {
            Console.WriteLine($"As Employee My Name is {_name}");
        }

        public override double Income()
        {
            throw new NotImplementedException();
        }

        public void OpenConnection()
        {
            throw new NotImplementedException();
        }

        public List<Employee> ReadAll()
        {
            throw new NotImplementedException();
        }

        public Employee ReadById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Employee Entity)
        {
            throw new NotImplementedException();
        }
    }
}

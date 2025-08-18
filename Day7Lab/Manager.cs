
namespace Day7Lab
{
    public class Manager : Human, IOperation<Manager>, IDbConnection
    {
        private string _name;
        public override string Name { get => _name; set => _name = value; }

        public void CloseConnection()
        {
            throw new NotImplementedException();
        }

        public void Create(Manager Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override void GetName()
        {
            Console.WriteLine($"As Manager My Name is {_name}");
        }

        public override double Income()
        {
            throw new NotImplementedException();
        }

        public void OpenConnection()
        {
            throw new NotImplementedException();
        }

        public List<Manager> ReadAll()
        {
            throw new NotImplementedException();
        }

        public Manager ReadById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Manager Entity)
        {
            throw new NotImplementedException();
        }
    }
}

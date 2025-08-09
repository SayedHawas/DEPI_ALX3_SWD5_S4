namespace Day7Lab
{
    public abstract class AbstractClassTwo : AbstractClassOne
    {
        public abstract void Edit();

    }

    public class test : AbstractClassOne
    {
        public override void Delete()
        {
            SayInfo();
            throw new NotImplementedException();
        }



        public override void Save()
        {
            throw new NotImplementedException();
        }
    }
}

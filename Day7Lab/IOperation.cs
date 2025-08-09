namespace Day7Lab
{
    //Non- Generic Interface 
    //public interface IOperation
    //{
    //    //Before .Net Core 8
    //    //public void Create()
    //    //{
    //    //     //Code 
    //    //}

    //    void Create();
    //    void Delete();
    //    void Update();
    //   void ReadAll();
    //    void ReadById(int id);
    //}
    public interface IOperation<T>
    {
        //Before .Net Core 8
        //public void Create()
        //{
        //     //Code 
        //}

        void Create(T Entity);
        void Delete(int id);
        void Update(T Entity);
        List<T> ReadAll();
        T ReadById(int id);
    }
}

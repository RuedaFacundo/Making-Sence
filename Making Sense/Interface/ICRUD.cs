namespace Making_Sense.Interface.ICarCrud
{
    public interface ICRUD<T>
    {
        T Create(T t);
        T Get(int id);
        T Update(T t);
        void Delete(int id);
    }
}

using System.Collections.Generic;

namespace Making_Sense.Interface
{
    public interface ICRUD<T>
    {
        T Create(T t);
        T Get(int id);
        T Update(T t);
        void Delete(int id);
        IEnumerable<T> GetAll();
    }
}

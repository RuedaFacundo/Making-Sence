namespace Making_Sense.Interface.IMethods
{
    public interface ICarCrud
    {
        Car Create(Car car);
        Car Get(int id);
        Car Update(Car car);
        void Delete(int id);
    }
}

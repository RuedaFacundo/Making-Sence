namespace Making_Sense.Interface.ICarCrud
{
    public interface ICarCrud
    {
        Car Create(Car car);
        Car Get(int id);
        Car Update(Car car);
        void Delete(int id);
    }
}

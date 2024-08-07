namespace DesignPatternsDemo.BuilderPattern
{
    public interface ICarBuilder
    {
        void SetModelNumber();
        void SetBrandName();
        void SetCarType();
        CarModel GetCar();
    }
}

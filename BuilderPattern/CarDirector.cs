namespace DesignPatternsDemo.BuilderPattern
{
    public class CarDirector
    {
        private ICarBuilder _builder;

        public CarDirector(ICarBuilder builder)
        {
            _builder  = builder;
        }

        public void BuildCar()
        {
            _builder.SetModelNumber();
            _builder.SetBrandName();
            _builder.SetCarType();
        }

        public CarModel GetCar()
        {
            return _builder.GetCar();
        }
    }
}

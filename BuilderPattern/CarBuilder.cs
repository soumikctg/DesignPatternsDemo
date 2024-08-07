namespace DesignPatternsDemo.BuilderPattern
{
    public class SportsCarBuilder : ICarBuilder
    {
        private readonly CarModel _car = new CarModel();

        public void SetBrandName()
        {
            _car.Brand = "SportsBrand";
        }

        public void SetCarType()
        {
            _car.Type = "Sports";
        }

        public void SetModelNumber()
        {
            _car.ModelNumber = "s1000";
        }

        public CarModel GetCar()
        {
            return _car;
        }
    }


    public class FamilyCarBuilder : ICarBuilder
    {
        private readonly CarModel _car = new CarModel();

        public void SetBrandName()
        {
            _car.Brand = "FamilyBrand";
        }

        public void SetCarType()
        {
            _car.Type = "Family";
        }

        public void SetModelNumber()
        {
            _car.ModelNumber = "f123";
        }

        public CarModel GetCar()
        {
            return _car;
        }
    }
}

using DesignPatternsDemo.BuilderPattern;

// Builder pattern builds a complex object using simple objects and using a step by step approach.

class Program
{
    static void Main(string[] args)
    {
        ICarBuilder sportCarBuilder = new SportsCarBuilder();
        CarDirector director = new CarDirector(sportCarBuilder);

        director.BuildCar();

        CarModel sportsCar = director.GetCar();
        Console.WriteLine(sportsCar);



        ICarBuilder familyCarBuilder = new FamilyCarBuilder();
        director = new CarDirector(familyCarBuilder);

        director.BuildCar();

        CarModel familyCar = director.GetCar();
        Console.WriteLine(familyCar);

    }
}

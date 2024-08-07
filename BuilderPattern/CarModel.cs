namespace DesignPatternsDemo.BuilderPattern
{
    public class CarModel
    {
        public string ModelNumber { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"Car Model: {ModelNumber}, Brand: {Brand}, Type: {Type}";
        }
    }
}

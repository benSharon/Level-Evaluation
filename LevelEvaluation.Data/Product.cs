namespace LevelEvaluation.Data
{
    public class Product
    {
        public string Name { get; }
        public double Price { get; }

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}

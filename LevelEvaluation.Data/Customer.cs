namespace LevelEvaluation.Data
{
    public class Customer:Person
    {
        public Cart Cart { get; }

        public Customer(string name) : base(name)
        {
            // TODO: Uncomment the line above once the first Person constructor is set
            Cart = new Cart();
        }
    }
}

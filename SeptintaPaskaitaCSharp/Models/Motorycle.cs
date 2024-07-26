namespace SeptintaPaskaitaCSharp.Models
{
    public class Motorycle : Vehicle
    {
        public bool SideCart { get; set; }

        public Motorycle() { }

        public Motorycle(bool sideCart, string brand, string model, int maxSpeed) : base(brand, model, maxSpeed)

        {
            SideCart = sideCart;
        }

        public override string ToString()
        {
            string hasCart = "does not have a cart attached";
            if (SideCart)
            {
                hasCart = "has a cart";
            }

            return $"Motorcycle {Brand} {Model} has Max Speed of {MaxSpeed} and {hasCart}.";
        }
    }
}

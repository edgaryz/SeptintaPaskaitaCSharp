namespace SeptintaPaskaitaCSharp.Models
{
    public class Car : Vehicle
    {
        public int Passengers { get; set; }

        public Car() { }

        public Car(int passengers, string brand, string model, int maxSpeed) : base(brand, model, maxSpeed)
        {
            Passengers = passengers;
        }

        public override string ToString()
        {
            return $"Motorcycle {Brand} {Model} has Max Speed of {MaxSpeed} and may carry {Passengers} passengers.";
        }
    }
}

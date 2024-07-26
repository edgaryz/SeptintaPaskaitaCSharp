namespace SeptintaPaskaitaCSharp.Models
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        protected int MaxSpeed { get; set; }

        public Vehicle() { }

        public Vehicle(string brand, string model, int maxSpeed)
        {
            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
        }
    }
}

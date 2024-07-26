using SeptintaPaskaitaCSharp.Models;

namespace SeptintaPaskaitaCSharp.Service
{
    public class Initialization
    {
        public void Initialize()
        {
            /* TASK 1 */
            Console.WriteLine("TASK 1");
            Vehicle lambo = new Car(2, "Lamborghini", "Huracan", 500);
            Vehicle ferrari = new Car(2, "Ferrari", "F40", 360);

            Vehicle ducati = new Motorycle(false, "Ducati", "Panigale V4", 600);
            Vehicle harley = new Motorycle(false, "Harley Davidson", "SCREAMIN EAGLE", 250);

            List<Vehicle> luxuryVehicles = new List<Vehicle>();

            luxuryVehicles.Add(lambo);
            luxuryVehicles.Add(ferrari);
            luxuryVehicles.Add(ducati);
            luxuryVehicles.Add(harley);

            foreach (var x in luxuryVehicles)
            {
                Console.WriteLine(x);
            }

            /* TASK 2 */
            Console.WriteLine("TASK 2");
            Worker coder = new Programmer("Plankalkul", "John", "Wick", 99999);
            Worker tester = new Tester(false,"Katy", "Perry", 900);

            List<Worker> itTeam = new List<Worker>();
            itTeam.Add(coder);
            itTeam.Add(tester);
            foreach (var x in itTeam)
            {
                Console.WriteLine(x);
            }
        }
    }
}

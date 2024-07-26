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
                if (x is Programmer)
                {
                    ((Programmer)x).Requalify("BASIC");
                } else if (x is Tester)
                {
                    ((Tester)x).Experienced(true);
                }

                Console.WriteLine(x);
            }

            /* TASK 3 */
            Console.WriteLine("TASK 3");
            Novel novelBook1 = new Novel("Romance", "Luka", "Doncic", 2000);
            Novel novelBook2 = new Novel("Drama", "Vika", "Doncic", 2001);

            ScienceBook scienceBook1 = new ScienceBook("Math", "Steven", "Right", 1996);
            ScienceBook scienceBook2 = new ScienceBook("Chemistry", "Lorrie", "Right", 1998);

            List<Book> bookShelf = new List<Book>();
            bookShelf.Add(novelBook1);
            bookShelf.Add(novelBook2);
            bookShelf.Add(scienceBook1);
            bookShelf.Add(scienceBook2);

            foreach (var x in bookShelf) 
            {
                Console.WriteLine(x);
            }

            /* TASK 4 */
            Console.WriteLine("TASK 4");

        }
    }
}

namespace SeptintaPaskaitaCSharp.Models
{
    public class Worker
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public double Salary { get; set; }

        public Worker() { }

        public Worker(string firstName, string lastName, double salary)
        {
            FirstName = firstName;
            Lastname = lastName;
            Salary = salary;
        }
    }
}

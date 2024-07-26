namespace SeptintaPaskaitaCSharp.Models
{
    public class Programmer : Worker
    {
        public string ProgrammingLanguage { get; set; }
        public Programmer() { }

        public Programmer(string programmingLanguage, string firstName, string lastName, double salary) : base(firstName, lastName, salary)
        {
            ProgrammingLanguage = programmingLanguage;
        }

        public void Requalify(string newLanguage)
        {
            ProgrammingLanguage = newLanguage;
        }

        public override string ToString()
        {
            return $"Programmer {FirstName} {Lastname}, Salary: {Salary} and works with {ProgrammingLanguage}.";
        }

    }
}

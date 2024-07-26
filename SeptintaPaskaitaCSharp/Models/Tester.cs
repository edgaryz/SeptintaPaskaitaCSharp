namespace SeptintaPaskaitaCSharp.Models
{
    public class Tester : Worker
    {
        public bool HasExperienceInAutomatedTesting { get; set; }

        public Tester(bool hasExperienceInAutomatedTesting, string firstName, string lastName, double salary) : base(firstName, lastName, salary)
        {
            HasExperienceInAutomatedTesting = hasExperienceInAutomatedTesting;
        }

        public void Experience(bool experience)
        {
            HasExperienceInAutomatedTesting = experience;
        }

        public override string ToString()
        {
            string hasExp = "does not have any experience in automated testing";
            if (HasExperienceInAutomatedTesting)
            {
                hasExp = "has experience in automated testing";
            }

            return $"Tester {FirstName} {Lastname}, Salary: {Salary} and {hasExp}.";
        }
    }


}

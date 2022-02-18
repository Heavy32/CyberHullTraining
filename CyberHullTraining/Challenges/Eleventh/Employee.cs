namespace CyberHullTraining.Challenges.Eleventh
{
    internal class Employee
    {
        public string Name { get; init; }
        public string FirstName { get; init; }
        public int Salary { get; init; }

        public virtual void Work()
        {
            Console.WriteLine("I'm working");
        }

        public void Pause()
        {
            Console.WriteLine("I'm having a break");
        }
    }
}

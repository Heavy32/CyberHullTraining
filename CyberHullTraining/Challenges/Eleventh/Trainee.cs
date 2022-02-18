namespace CyberHullTraining.Challenges.Eleventh
{
    internal class Trainee : Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public void Learn()
        {
            Console.WriteLine("I'm learning for {0} hours!", SchoolHours);
        }

        public override void Work()
        {
            Console.WriteLine("I work for {0} hours", WorkingHours);
        }

    }
}

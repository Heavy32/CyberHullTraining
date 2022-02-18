namespace CyberHullTraining.Challenges.Eleventh
{
    internal class Boss : Employee
    {
        public string CompanyCar { get; init; }

        public void Lead()
        {
            Console.WriteLine("I'm boss! My name is {0} {1}", FirstName, Name);
        }
    }
}

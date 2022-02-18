namespace CyberHullTraining.Challenges.Nineth
{
    internal sealed class NinethChallenge : IChallenge
    {
        public void Act()
        {
            string[][] friends = new string[][]
            {
                new string[] {"Helen", "Alex"},
                new string[] {"Mary", "Peter"},
                new string[] {"Ivan", "Patrick"}
            };

            Console.WriteLine($"Hi, {friends[0][0]}, I would like to introduce {friends[1][0]} to you");
            Console.WriteLine($"Hi, {friends[0][1]}, I would like to introduce {friends[2][0]} to you");
            Console.WriteLine($"Hi, {friends[0][1]}, I would like to introduce {friends[2][1]} to you");
        }
    }
}

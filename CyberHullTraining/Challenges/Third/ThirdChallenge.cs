namespace CyberHullTraining.Challenges.Third
{
    public class ThirdChallenge : IChallenge
    {
        public void Act()
        {
            IEnumerable<string> friends = new string[] { "Helen", "Ivan", "Alex" };

            foreach (var friend in friends)
            {
                GreetFriends(friend);
            }
        }

        private void GreetFriends(string friend)
        {
            Console.WriteLine($"Hello, {friend}, my friend!");
        }
    }
}

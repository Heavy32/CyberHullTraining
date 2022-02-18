namespace CyberHullTraining.Challenges.Sixth
{
    internal sealed class SixthChallenge : IChallenge
    {
        public void Act()
        {
            ICollection<int> scores = new List<int>();

            int inputScore;
            while(true)
            {
                Console.WriteLine("Enter score. If you want to finish, enter -1");
                inputScore = Convert.ToInt32(Console.ReadLine());

                if(inputScore == -1)
                {
                    break;
                }

                if(inputScore < 0 && inputScore > 20)
                {
                    Console.WriteLine("Score must be between 0 and 20. Please try again");
                }
                else 
                {
                    scores.Add(inputScore);
                }
            }

            double averageScore = scores.Count != 0 ? scores.Average() : 0;
            Console.WriteLine($"Average score of students is {averageScore}");
        }
    }
}

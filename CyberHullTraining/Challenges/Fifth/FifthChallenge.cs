namespace CyberHullTraining.Challenges.Fifth
{
    internal sealed class FifthChallenge : IChallenge
    {
        public void Act()
        {
            int highestScore = 1000;
            string highscorePlayer = "Master";

            Console.WriteLine("Enter your name");
            string inputName = Console.ReadLine();

            Console.WriteLine("Enter your score");
            int inputScore = Convert.ToInt32(Console.ReadLine());

            if(inputScore > highestScore)
            {
                Console.WriteLine(
                    $"New highscore is {inputScore}" + Environment.NewLine +
                    $"New highscore holder is + {inputName}");
            }
            else
            {
                Console.WriteLine($"The old highscore of {highestScore} could not be broken and is still held by {highscorePlayer}");
            }
        }
    }
}

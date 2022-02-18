namespace CyberHullTraining.Challenges.First
{
    internal sealed class FirstChallenge : IChallenge
    {
        public void Act()
        {
            Console.WriteLine("Write a string you want to display");
            string inputString = Console.ReadLine();

            Console.WriteLine("Write a length of substring");
            int inputSubstringLength = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine(FormatString(inputString, inputSubstringLength));
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private string FormatString(string source, int substringLength)
        {
            if (source.Length < substringLength)
            {
                throw new ArgumentException("input string should not be less that substring length", nameof(substringLength));
            }

            //Ofcourse we could use StringBuilder, if the output string was more complicated 
            return
                source.ToUpper() + Environment.NewLine +
                source.ToLower() + Environment.NewLine +
                source.Trim() + Environment.NewLine +
                source.Substring(0, substringLength);
        }
    }
}

namespace CyberHullTraining.Challenges.Fourth
{
    internal sealed class FourthChallenge : IChallenge
    {
        private readonly IUserRepository userRepository;

        public FourthChallenge(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void Act()
        {
            Console.WriteLine("Please enter your name");
            string inputUserName = Console.ReadLine();

            Console.WriteLine("Please enter your password");
            string inputPassword = Console.ReadLine();

            User user = new()
            {
                Name = inputUserName,
                Password = inputPassword
            };

            bool isSignedIn = IsUserRSignedIn(user);

            if (!isSignedIn)
            {
                SignIn(user);
                Console.WriteLine("You're signed in!");
            }

            Console.WriteLine($"Hello, {inputUserName}!");
        }

        private bool IsUserRSignedIn(User user)
        {
            return userRepository.GetUsers().Any(storedUser => storedUser == user);
        }

        private void SignIn(User user)
        {
            userRepository.AddUser(user);
        }
    }
}

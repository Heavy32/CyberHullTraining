namespace CyberHullTraining.Challenges.Fourth
{
    internal sealed class InMemoryUserRepository : IUserRepository
    {
        private ICollection<User> Users { get; } = new List<User>
            {
                new User
                {
                    Name = "Helen",
                    Password = "12345"
                },
                new User
                {
                    Name = "Max",
                    Password = "999"
                }
            };

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public IEnumerable<User> GetUsers() => Users;
    }
}

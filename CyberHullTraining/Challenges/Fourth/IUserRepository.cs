namespace CyberHullTraining.Challenges.Fourth
{
    internal interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        void AddUser(User user);
    }
}

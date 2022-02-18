namespace CyberHullTraining.Challenges.Eleventh
{
    internal sealed class EleventhChallenge : IChallenge
    {
        public void Act()
        {

            Employee alex =
                new()
                {
                    Name = "Alex",
                    Salary = 120000,
                    FirstName = "Rogerson"
                };
            alex.Work();
            alex.Pause();

            Boss ivan = 
                new()
                {
                    Name = "Ivan",
                    Salary = 300000,
                    CompanyCar = "BMW",
                    FirstName = "Ivanov"
                };
            ivan.Lead();

            Trainee john =
                new()
                {
                    Name = "John",
                    Salary = 50000,
                    SchoolHours = 20,
                    FirstName = "Black",
                    WorkingHours = 20
                };
            john.Learn();
            john.Work();
        }
    }
}

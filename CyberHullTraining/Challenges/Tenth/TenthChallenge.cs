using System.Collections;

namespace CyberHullTraining.Challenges.Tenth
{
    public class TenthChallenge : IChallenge
    {
        public void Act()
        {
            Student[] students =
            {
                new Student {Id = 1, Name = "Alex", Score = 100},
                new Student {Id = 2, Name = "George", Score = 90},
                new Student {Id = 3, Name = "Mary", Score = 88}
            };

            Hashtable hashtable = new();

            foreach (var student in students)
            {
                if (!hashtable.ContainsKey(student.Id))
                {
                    hashtable.Add(student.Id, student);
                }
                else
                {
                    Console.WriteLine($"Sorry, a student with the same Id {student.Id} already exists");
                }
            }
        }
    }
}

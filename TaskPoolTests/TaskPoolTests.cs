using CyberHullTraining;
using NUnit.Framework;
using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace TaskPoolTests
{
    public class TaskPoolTests
    {
        [Repeat(3)]
        [TestCase(100, 1000)]
        public async Task Test(int parallelism, int maxTaskCount)
        {
            //Arrange
            int sharedNumber = 0;
            ConcurrentQueue<string> strings = new ConcurrentQueue<string>();

            for (int i = 0; i < maxTaskCount; i++)
            {
                strings.Enqueue("Some message");
            }

            Func<Task> taskMaker =
                () =>
                {
                    if (strings.Count == 0)
                        return null;

                    return Task.Run(
                        async () =>
                        {
                            Interlocked.Increment(ref sharedNumber);
                            await Task.Delay(10);
                            Interlocked.Decrement(ref sharedNumber);
                            strings.TryDequeue(out var message);
                            Console.WriteLine(message);
                        });
                };

            TaskPool taskPool = new TaskPool(new StringBuilderLogger());

            //Act
            await taskPool.RunTask(taskMaker, parallelism);

            //Assert
            Assert.IsTrue(sharedNumber <= parallelism);
        }
    }
}
using System.Collections.Concurrent;

namespace CyberHullTraining
{
    public sealed class TaskPool
    {
        private readonly ILogger _logger;

        public TaskPool(ILogger logger)
        {
            _logger = logger;
        }

        public async Task RunTask(Func<Task> createNextTask, int parallelism)
        {
            if (createNextTask == null)
            {
                throw new ArgumentNullException(nameof(createNextTask));
            }

            if (parallelism == 0)
            {
                throw new ArgumentException(nameof(parallelism));
            }

            bool isFinished = false;

            BlockingCollection<TaskPoolUnit> tasks = new(parallelism);

            while (!isFinished)
            {
                while (tasks.Count < tasks.BoundedCapacity)
                {
                    var task = createNextTask();

                    if (task == null)
                    {
                        isFinished = true;
                        break;
                    }

                    tasks.Add(
                        new TaskPoolUnit
                        {
                            Source = tasks,
                            Unit = task
                        });
                }

                try
                {
                    await Task.WhenAll(tasks.Select(taskPoolUnit => taskPoolUnit.CompleteTask()));
                }
                catch (Exception exception)
                {
                    _logger.LogMessage(exception.ToString());
                    throw;
                }
            }
        }
    }
}

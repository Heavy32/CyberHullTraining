using System.Collections.Concurrent;

namespace CyberHullTraining
{
    public sealed class TaskPoolUnit
    {
        public Task Unit { get; set; }
        /// <summary>
        /// A collection where TaskPoolUnit is contained
        /// </summary>
        public BlockingCollection<TaskPoolUnit> Source { get; set; }

        public async Task CompleteTask()
        {
            try
            {
                await Unit;
            }
            finally
            {
                Source.Remove(this);
            }
        }
    }
}

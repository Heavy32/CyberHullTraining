namespace CyberHullTraining
{
    public interface ILogger
    {
        public void LogMessage(string message);
        public string GetMessage();
    }
}

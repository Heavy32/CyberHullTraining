using System.Text;

namespace CyberHullTraining
{
    public class StringBuilderLogger : ILogger
    {
        private readonly StringBuilder _stringBuilder = new();

        public string GetMessage()
        {
            return _stringBuilder.ToString();
        }

        public void LogMessage(string message)
        {
            _stringBuilder.AppendLine(message);
        }
    }
}

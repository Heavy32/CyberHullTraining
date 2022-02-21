namespace CyberHullTraining
{
    public sealed class Step
    {
        public string Description { get; init; }
        public TimeSpan CookingTime { get; init; }
        public ICollection<Product> Products { get; init; } = new List<Product>();
    }
}

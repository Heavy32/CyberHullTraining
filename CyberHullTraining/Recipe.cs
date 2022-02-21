namespace CyberHullTraining
{
    public sealed record Recipe
    {
        public string Name { get; init; }
        public ICollection<Step> Steps { get; init; } = new List<Step>();
        public MealEnum Meal { get; init; }

        public void AddRecipe(Step step)
        {
            Steps.Add(step);
        }

        public void Remove(Step step)
        {
            Steps.Remove(step);
        }
    }
}

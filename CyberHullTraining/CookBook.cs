namespace CyberHullTraining
{
    public sealed class CookBook
    {
        public string Name { get; init; }
        public ICollection<Recipe> Recipes { get; init; } = new List<Recipe>();

        public void AddRecipe(Recipe recipe)
        {
            // Better comparison with custom comparator                 
            if (Recipes.Any(r => r.Name == recipe.Name))
            {
                throw new RecipeExistsInCookBookException(recipe.Name);
            }
            Recipes.Add(recipe);
        }

        public TimeSpan GetRecipeCookingTime(Recipe recipe)
        {
            return recipe.Steps.Select(step => step.CookingTime).Aggregate((timeSum, time) => timeSum + time);
        }

        //async + async test, call this method from different threads
        public IEnumerable<Product> GetUniqueProductsFromRecipe(Recipe recipe)
        {
            return recipe.Steps.Select(step => step.Products).SelectMany(products => products).Distinct();
        }

        public int NewMealsEachDayCount()
        {
            //add comments
            return Recipes.GroupBy(recipe => recipe.Meal, recipe => recipe).Min(group => group.Count());
        }

        //parallel calc for 5, first 1, first 2, first 3 etc
        public IDictionary<string, int> GetShoppingList(IEnumerable<Recipe> recipes)
        {
            return recipes
                .Select(recipe => recipe.Steps)
                .SelectMany(steps => steps)
                .SelectMany(step => step.Products)
                .GroupBy(product => product.Name)
                .ToDictionary(productGroup => productGroup.Key, productGroup => productGroup.Count());
        }
    }
}

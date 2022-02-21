namespace CyberHullTraining
{
    public class RecipeExistsInCookBookException : Exception
    {
        public RecipeExistsInCookBookException(string recipeName) : base(string.Format("Recipe already exists in the cookBook {0}", recipeName))
        {
        }
    }
}

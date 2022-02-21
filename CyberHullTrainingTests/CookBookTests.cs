using CyberHullTraining;
using CyberHullTrainingTests.TestCaseSource;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CyberHullTrainingTests
{
    public class CookBookTests
    {
        [TestCaseSource(typeof(CookBookTestCases), nameof(CookBookTestCases.CookBooks))]
        public void AddRecipe_ThrowRecipeExistsInCookBookException(CookBook cookBook)
        {
            //Arrange
            var duplicatedRecipe = new Recipe
            {
                Name = "Porridge",
                Meal = MealEnum.Breakfast,
                Steps = new List<Step>
                        {
                            new Step
                            {
                                Description = "Boil water",
                                CookingTime = new TimeSpan(0, 5, 0),
                                Products = new List<Product>
                                {
                                    new Product
                                    {
                                        Name = "Water"
                                    }
                                }
                            },
                            new Step
                            {
                                Description = "Add porridge and wait 10 minutes",
                                CookingTime = new TimeSpan(0, 10, 0),
                                Products = new List<Product>
                                {
                                    new Product
                                    {
                                        Name = "Porridge"
                                    }
                                }
                            }
                        }
            };

            //Act && Assert          
            Assert.Throws<RecipeExistsInCookBookException>(() => cookBook.AddRecipe(duplicatedRecipe));
        }

        [TestCaseSource(typeof(CookBookTestCases), nameof(CookBookTestCases.CookBooks))]
        public void GetRecipeCookingTimeTest_Return15Minutes(CookBook cookBook)
        {
            //Arrange
            Recipe recipeToTimeCalculate = cookBook.Recipes.First(recipe => recipe.Name == "Porridge");
            TimeSpan expectedCookingTime = new TimeSpan(0, 15, 0);

            //Act
            TimeSpan actualCookingTime = cookBook.GetRecipeCookingTime(recipeToTimeCalculate);

            //Assert
            Assert.AreEqual(expectedCookingTime, actualCookingTime);
        }

        [TestCaseSource(typeof(CookBookTestCases), nameof(CookBookTestCases.CookBooks))]
        public void GetProductsFromRecipeTest_ReturnWaterPorridge(CookBook cookBook)
        {
            //Arrange
            Recipe recipe = cookBook.Recipes.First(recipe => recipe.Name == "Porridge");
            IEnumerable<Product> expectedProducts = new Product[]
            {
                new Product
                {
                    Name = "Water"
                },
                new Product
                {
                    Name = "Porridge"
                }
            };

            //Act
            IEnumerable<Product> actualProducts = cookBook.GetUniqueProductsFromRecipe(recipe);

            //Assert
            CollectionAssert.AreEqual(expectedProducts, actualProducts);
        }

        [TestCaseSource(typeof(CookBookTestCases), nameof(CookBookTestCases.CookBooks))]
        public void NewMealsEachDaysCountTest_Return2(CookBook cookBook)
        {
            //Arrange
            int expectedCount = 2;

            //Act
            int actualCount = cookBook.NewMealsEachDayCount();

            //Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestCaseSource(typeof(CookBookTestCases), nameof(CookBookTestCases.CookBooks))]
        public void GetShoppingListTest(CookBook cookBook)
        {
            //Arrange
            IEnumerable<Recipe> recipes = cookBook.Recipes.Take(1);

            IDictionary<string, int> expectedProductCounts = new Dictionary<string, int>
            {
                { "Water", 1 },
                { "Porridge", 1 }
            };

            //Act
            IDictionary<string, int> actualProductCounts = cookBook.GetShoppingList(recipes);

            //Assert
            CollectionAssert.AreEqual(expectedProductCounts, actualProductCounts);
        }
    }
}
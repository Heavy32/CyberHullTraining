using CyberHullTraining;
using System;
using System.Collections.Generic;

namespace CyberHullTrainingTests.TestCaseSource
{
    public class CookBookTestCases
    {
        public static CookBook[] CookBooks =
        {
            new CookBook
            {
                Name = "MyCookBook",
                Recipes = new List<Recipe>
                {
                    new Recipe
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
                    },
                    new Recipe
                    {
                        Name = "Fried egg",
                        Meal = MealEnum.Breakfast,
                        Steps = new List<Step>
                        {
                            new Step
                            {
                                Description = "Heat up the pan and add oil",
                                CookingTime = new TimeSpan(0, 5, 0),
                                Products = new List<Product>
                                {
                                    new Product
                                    {
                                        Name = "Oil"
                                    }
                                }
                            },
                            new Step
                            {
                                Description = "Add mashrooms, onion, tomato",
                                CookingTime = new TimeSpan(0, 3, 0),
                                Products = new List<Product>
                                {
                                    new Product
                                    {
                                        Name = "Mashrooms"
                                    },
                                    new Product
                                    {
                                        Name = "Onion"
                                    },
                                    new Product
                                    {
                                        Name = "Tomato"
                                    }
                                }
                            },
                            new Step
                            {
                                Description = "Add 3 eggs and fry for 5 minutes",
                                CookingTime = new TimeSpan (0, 5, 0),
                                Products = new List<Product>
                                {
                                    new Product
                                    {
                                        Name = "Egg"
                                    },
                                    new Product
                                    {
                                        Name = "Egg"
                                    },
                                    new Product
                                    {
                                        Name = "Egg"
                                    }
                                }
                            }
                        }
                    },
                    new Recipe
                    {
                        Name = "Cream soup",
                        Meal = MealEnum.Lunch,
                        Steps = new List<Step>
                        {
                            new Step
                            {
                                Description = "Boil 5 potatoes",
                                CookingTime = new TimeSpan(0, 20, 0),
                                Products = new List<Product>
                                {
                                    new Product
                                    {
                                        Name = "Potato"
                                    },
                                    new Product
                                    {
                                        Name = "Potato"
                                    },
                                    new Product
                                    {
                                        Name = "Potato"
                                    },
                                    new Product
                                    {
                                        Name = "Potato"
                                    },
                                    new Product
                                    {
                                        Name = "Potato"
                                    }
                                }
                            },
                            new Step
                            {
                                Description = "Fry mashrooms",
                                CookingTime = new TimeSpan(0, 5, 0),
                                Products = new List<Product>
                                {
                                    new Product
                                    {
                                        Name = "Mashrooms"
                                    }
                                }
                            },
                            new Step
                            {
                                Description = "Mix in a mixer and add some greenery",
                                CookingTime = new TimeSpan(0, 5, 0),
                                Products = new List<Product>
                                {
                                    new Product
                                    {
                                        Name = "Greenery"
                                    }
                                }
                            }
                        }
                    },
                    new Recipe
                    {
                        Name = "Rice with chicken",
                        Meal = MealEnum.Lunch,
                        Steps = new List<Step>
                        {
                            new Step
                            {
                                Description = "Boid rice",
                                CookingTime = new TimeSpan(0, 15, 0),
                                Products = new List<Product>
                                {
                                    new Product
                                    {
                                        Name = "Rice"
                                    }
                                }
                            },
                            new Step
                            {
                                Description = "Fry chicken in a pan",
                                CookingTime = new TimeSpan (0, 10, 0),
                                Products = new List<Product>
                                {
                                    new Product
                                    {
                                        Name = "Chincken"
                                    }
                                }
                            },
                            new Step
                            {
                                Description = "Add rice in a pan and fry 3 minutes",
                                CookingTime = new TimeSpan(0, 3, 0)
                            }
                        }
                    },
                    new Recipe
                    {
                        Name = "Pasta",
                        Meal = MealEnum.Lunch,
                        Steps = new List<Step>
                        {
                            new Step
                            {
                                Description = "Boil pasta",
                                CookingTime = new TimeSpan(0, 10, 0),
                                Products = new List<Product>
                                {
                                    new Product
                                    {
                                        Name = "Pasta"
                                    }
                                }
                            },
                            new Step
                            {
                                Description = "Fry bacon with onion in a pan",
                                CookingTime = new TimeSpan(0, 5, 0),
                                Products = new List<Product>
                                {
                                    new Product
                                    {
                                        Name = "Bacon"
                                    },
                                    new Product
                                    {
                                        Name = "Onion"
                                    }
                                }
                            },
                            new Step
                            {
                                Description = "Add fried bacon and onion to pasta, add some cheese and wait 3 minutes",
                                CookingTime = new TimeSpan(0, 3, 0),
                                Products = new List<Product>
                                {
                                    new Product
                                    {
                                        Name = "Cheese"
                                    }
                                }
                            }
                        }
                    },
                    new Recipe
                    {
                        Name = "Vegetable stew",
                        Meal = MealEnum.Dinner,
                        Steps = new List<Step>
                        {
                            new Step
                            {
                                Description = "Cut eggplant, potatoe, tomatoe, zucchini",
                                CookingTime = new TimeSpan(0, 5, 0),
                                Products = new List<Product>
                                {
                                    new Product
                                    {
                                        Name = "Eggplant"
                                    },
                                    new Product
                                    {
                                        Name = "Potato"
                                    },
                                    new Product
                                    {
                                        Name = "Zucchini"
                                    }
                                }
                            },
                            new Step
                            {
                                Description = "Add to slow cooker and simmer for 20 minutes",
                                CookingTime = new TimeSpan(0, 20, 0)
                            }
                        }
                    },
                    new Recipe
                    {
                        Name = "Grilled chicken",
                        Meal = MealEnum.Dinner,
                        Steps = new List<Step>
                        {
                            new Step
                            {
                                Description = "Butcher the chicken",
                                CookingTime = new TimeSpan(0, 10, 0),
                                Products = new List<Product>
                                {
                                    new Product
                                    {
                                        Name = "Chicken"
                                    }
                                }
                            },
                            new Step
                            {
                                Description = "Put the chicken on the grill and roast it for 20 minutes",
                                CookingTime = new TimeSpan(0, 20, 0),
                            },
                            new Step
                            {
                                Description = "Remove chicken from grill and add greenery",
                                CookingTime = new TimeSpan(0, 1, 0),
                                Products = new List<Product>
                                {
                                    new Product
                                    {
                                        Name = "Greenery"
                                    }
                                }
                            }
                        }
                    }
                }
            }
        };
    }
}

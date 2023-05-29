using PartTwo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartTwo
{
    internal class Ingredients
    {
        // These static lists will store the data entered by the user.
        private static List<List<string>> recipeNamesList = new List<List<string>>();
        private static List<List<int>> ingredientQuantitiesList = new List<List<int>>();
        private static List<List<string>> ingredientNamesList = new List<List<string>>();
        private static List<List<string>> unitOfMeasurementList = new List<List<string>>();
        private static List<List<string>> caloriesList = new List<List<string>>();
        private static List<List<string>> foodGroupList = new List<List<string>>();
        private static List<List<string>> descriptionOfStepsList = new List<List<string>>();

        // Define a delegate type for notifying the user
        public delegate void RecipeCaloriesExceededHandler();

        // Declare an event of the delegate type
        public static event RecipeCaloriesExceededHandler RecipeCaloriesExceededEvent;

        // Property to access recipe names list
        public static List<List<string>> RecipeNamesList
        {
            get { return recipeNamesList; }
            set { recipeNamesList = value; }
        }

        // Property to access ingredient quantities list
        public static List<List<int>> IngredientQuantitiesList
        {
            get { return ingredientQuantitiesList; }
            set { ingredientQuantitiesList = value; }
        }

        // Property to access ingredient names list
        public static List<List<string>> IngredientNamesList
        {
            get { return ingredientNamesList; }
            set { ingredientNamesList = value; }
        }

        // Property to access unit of measurement list
        public static List<List<string>> UnitOfMeasurementList
        {
            get { return unitOfMeasurementList; }
            set { unitOfMeasurementList = value; }
        }

        // Property to access calories list
        public static List<List<string>> CaloriesList
        {
            get { return caloriesList; }
            set { caloriesList = value; }
        }

        // Property to access food group list
        public static List<List<string>> FoodGroupList
        {
            get { return foodGroupList; }
            set { foodGroupList = value; }
        }

        // Property to access description of steps list
        public static List<List<string>> DescriptionOfStepsList
        {
            get { return descriptionOfStepsList; }
            set { descriptionOfStepsList = value; }
        }

        // This method prompts the user to input the ingredient details and stores them in the static lists.
        public static void InputtingIngredients()
        {
            // Prompt user for recipe name
            Console.Write("Enter recipe name: ");
            string recipeName = Console.ReadLine();

            List<int> ingredientQuantities = new List<int>();
            List<string> ingredientNames = new List<string>();
            List<string> unitOfMeasurements = new List<string>();
            List<string> calories = new List<string>();
            List<string> foodGroups = new List<string>();
            List<string> descriptionOfSteps = new List<string>();

            // Prompt user for number of ingredients
            Console.Write("How many Ingredients would you like to add: ");
            int numOfIngredients;
            while (!int.TryParse(Console.ReadLine(), out numOfIngredients))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Invalid input. Please enter a number: ");
            }

            // Define the food group options
            Dictionary<int, string> foodGroupOptions = new Dictionary<int, string>
            {
                { 1, "Starchy foods" },
                { 2, "Vegetables and fruits" },
                { 3, "Dry beans, peas, lentils and soya" },
                { 4, "Chicken, fish, meat and eggs" },
                { 5, "Milk and dairy products" },
                { 6, "Fats and oil" },
                { 7, "Water" }
            };

            for (int i = 0; i < numOfIngredients; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("What is the name of ingredient " + (i + 1) + ": ");
                string ingredientName = Console.ReadLine();
                ingredientNames.Add(ingredientName);

                Console.Write("What is the quantity of ingredient " + (i + 1) + ": ");
                int ingredientQuantity;
                while (!int.TryParse(Console.ReadLine(), out ingredientQuantity))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Invalid input. Please enter a number: ");
                }
                ingredientQuantities.Add(ingredientQuantity);

                Console.Write("What is the unit of measurement of ingredient " + (i + 1) + ": ");
                string unitOfMeasurement = Console.ReadLine();
                unitOfMeasurements.Add(unitOfMeasurement);

                Console.Write("What is the number of calories of ingredient " + (i + 1) + ": ");
                string caloriesInput = Console.ReadLine();
                calories.Add(caloriesInput);

                Console.WriteLine("Food Group Options:");
                foreach (var option in foodGroupOptions)
                {
                    Console.WriteLine(option.Key + ". " + option.Value);
                }

                int foodGroupOption;
                do
                {
                    Console.Write("Enter the number for the food group of ingredient " + (i + 1) + ": ");
                } while (!int.TryParse(Console.ReadLine(), out foodGroupOption) || !foodGroupOptions.ContainsKey(foodGroupOption));

                string foodGroup = foodGroupOptions[foodGroupOption];
                foodGroups.Add(foodGroup);
            }

            // Prompt user for number of steps
            Console.Write("How many steps are there: ");
            int numOfSteps;
            while (!int.TryParse(Console.ReadLine(), out numOfSteps))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Invalid input. Please enter a number: ");
            }

            for (int i = 0; i < numOfSteps; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Step " + (i + 1) + ": ");
                string stepDescription = Console.ReadLine();
                descriptionOfSteps.Add(stepDescription);
            }

            // Add the entered data to the respective lists
            recipeNamesList.Add(new List<string> { recipeName });
            ingredientQuantitiesList.Add(ingredientQuantities);
            ingredientNamesList.Add(ingredientNames);
            unitOfMeasurementList.Add(unitOfMeasurements);
            caloriesList.Add(calories);
            foodGroupList.Add(foodGroups);
            descriptionOfStepsList.Add(descriptionOfSteps);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nYou have entered the details successfully");

            // Calls the MainMenu method in the RecipeApp class to go back to the main menu.
            RecipeApp.MainMenu();
        }

        // This method calculates the total calories based on the provided list of calories.
        private static int CalculateTotalCalories(List<string> calories)
        {
            int totalCalories = 0;
            foreach (string calorie in calories)
            {
                if (int.TryParse(calorie, out int ingredientCalories))
                {
                    totalCalories += ingredientCalories;
                }
            }
            return totalCalories;
        }

        // This method is called when the total calories of a recipe exceed 300.
        private static void RecipeCaloriesExceededNotification()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Warning: The total calories of this recipe exceed 300.");
        }
        // This method displays the list of recipes in alphabetical order by name.
        public static void DisplayRecipeList()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*********************************");
            Console.WriteLine("        Recipe List \n");
            Console.WriteLine("*********************************");

            // Sort the recipes by name
            List<string> recipeNames = new List<string>();
            for (int i = 0; i < recipeNamesList.Count; i++)
            {
                if (recipeNamesList[i].Count > 0)
                {
                    recipeNames.Add(recipeNamesList[i][0]);
                }
            }
            recipeNames.Sort();

            // Display the sorted recipe names
            for (int i = 0; i < recipeNames.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + recipeNames[i]);
            }

            Console.WriteLine("*********************************");

            // Prompt the user to choose a recipe to display
            Console.Write("Enter the number of the recipe you want to display (or 0 to go back to the main menu): ");
            int recipeIndex;
            while (!int.TryParse(Console.ReadLine(), out recipeIndex))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Invalid input. Please enter a number: ");
            }

            if (recipeIndex >= 1 && recipeIndex <= recipeNames.Count)
            {
                // Display the chosen recipe
                DisplayRecipe(recipeIndex - 1);
            }
            else if (recipeIndex == 0)
            {
                RecipeApp.MainMenu();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid recipe number. Please try again.");
                DisplayRecipeList();
            }
        }

        // This method displays the details of a specific recipe.
        public static void DisplayRecipe(int recipeIndex)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*********************************");
            Console.WriteLine("        Recipe Display \n");
            Console.WriteLine("*********************************");

            // Retrieve the data for the chosen recipe from the lists
            List<int> ingredientQuantities = ingredientQuantitiesList[recipeIndex];
            List<string> ingredientNames = ingredientNamesList[recipeIndex];
            List<string> unitOfMeasurements = unitOfMeasurementList[recipeIndex];
            List<string> calories = caloriesList[recipeIndex];
            List<string> foodGroups = foodGroupList[recipeIndex];
            List<string> descriptionOfSteps = descriptionOfStepsList[recipeIndex];

            Console.WriteLine("Recipe Name: " + recipeNamesList[recipeIndex][0]);
            Console.WriteLine("Ingredients: " + ingredientNamesList[recipeIndex][0] + "\n");

            Console.WriteLine("*********************************");
            Console.WriteLine("Number of Ingredients: " + ingredientQuantities.Count + "\n");

            int totalCalories = 0;

            // Display the details of each ingredient
            for (int j = 0; j < ingredientNames.Count; j++)
            {
                Console.WriteLine("Name of Ingredient: " + ingredientNames[j]);
                Console.WriteLine("Quantity of Ingredient: " + ingredientQuantities[j]);
                Console.WriteLine("Unit of Measurement: " + unitOfMeasurements[j]);
                Console.WriteLine("Calories: " + calories[j]);
                Console.WriteLine("Food Group: " + foodGroups[j] + "\n");

                int ingredientCalories;
                if (int.TryParse(calories[j], out ingredientCalories))
                {
                    totalCalories += ingredientCalories;
                }
            }

            Console.WriteLine("Total Calories: " + totalCalories);

            if (totalCalories > 300)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Warning: The total calories of this recipe exceed 300.");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n          Steps");
            Console.WriteLine("*********************************");

            // Display the description of each step
            for (int k = 0; k < descriptionOfSteps.Count; k++)
            {
                Console.WriteLine("Step " + (k + 1) + ": " + descriptionOfSteps[k]);
            }

            Console.WriteLine("*********************************");

            // Calls the MainMenu method in the RecipeApp class to go back to the main menu.
            RecipeApp.MainMenu();
        }

        // This method clears all the entered recipe data.
        public static void ClearData()
        {
            // Clear all the lists
            recipeNamesList.Clear();
            ingredientQuantitiesList.Clear();
            ingredientNamesList.Clear();
            unitOfMeasurementList.Clear();
            caloriesList.Clear();
            foodGroupList.Clear();
            descriptionOfStepsList.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nThe recipe data has been cleared.");

            // Calls the MainMenu method in the RecipeApp class to go back to the main menu.
            RecipeApp.MainMenu();
        }
    }
}

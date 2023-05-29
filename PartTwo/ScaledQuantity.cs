using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartTwo
{
    internal class ScaledQuantity
    {
        // Declare a static instance of Ingredients
        public static Ingredients myIngri = new Ingredients();

        // Declare an integer variable to store the option of scale
        private static int optionOfScale = 0;

        public static int OptionScale
        {
            get { return optionOfScale; }
            set { optionOfScale = value; }
        }

        public static double halfScale = 0.5;
        public static double doubleScale = 2;
        public static double trippleScale = 3;

        // Create a static method to change the scaled quantity
        public static void ChangingScaledQuantity()
        {
            // Use a while loop to display the options and prompt for input until optionOfScale is greater than or equal to 3
            while (optionOfScale < 3)
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\nWhat scale would you like to change the quantity to: \n" +
                        "1. Half \n" +
                        "2. Double \n" +
                        "3. Triple \n" +
                        "Input option: ");

                    try
                    {
                        optionOfScale = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("You made an incorrect input. Please try again: ");
                        optionOfScale = 0; // set to 0 to keep the loop running
                    }
                } while (optionOfScale < 1 || optionOfScale > 3); // keep looping until user input is correct

                // Use a switch statement to perform different actions based on the user's input
                switch (optionOfScale)
                {
                    case 1:
                        // Use a for loop to iterate through the ingredients and update their quantities to half
                        for (int i = 0; i < Ingredients.IngredientQuantitiesList.Count; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Ingredients.IngredientQuantitiesList[i][0] = (int)(Ingredients.IngredientQuantitiesList[i][0] * halfScale);
                            Console.WriteLine("Quantity " + (i + 1) + ": " + Ingredients.IngredientQuantitiesList[i][0]);
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have successfully changed the quantity to half.");
                        break;
                    case 2:
                        // Use a for loop to iterate through the ingredients and update their quantities to double
                        for (int i = 0; i < Ingredients.IngredientQuantitiesList.Count; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Ingredients.IngredientQuantitiesList[i][0] = (int)(Ingredients.IngredientQuantitiesList[i][0] * doubleScale);
                            Console.WriteLine("Quantity " + (i + 1) + ": " + Ingredients.IngredientQuantitiesList[i][0]);
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have successfully changed the quantity to double.");
                        break;
                    case 3:
                        // Use a for loop to iterate through the ingredients and update their quantities to triple
                        for (int i = 0; i < Ingredients.IngredientQuantitiesList.Count; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Ingredients.IngredientQuantitiesList[i][0] = (int)(Ingredients.IngredientQuantitiesList[i][0] * trippleScale);
                            Console.WriteLine("Quantity " + (i + 1) + ": " + Ingredients.IngredientQuantitiesList[i][0]);
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have successfully changed the quantity to triple.");
                        break;
                }

                // Call the MainMenu() method of the RecipeApp class to return to the main menu
                RecipeApp.MainMenu();
            }
           
        }

        // Create a static method to reset the scaled quantity
        public static void ResettingScaledQuantity()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            // Use a for loop to iterate through the ingredients and update their quantities based on the scaling factor
            for (int j = 0; j < Ingredients.IngredientQuantitiesList.Count; j++)
            {
                // Using a switch statement to check the option used for scaling
                switch (optionOfScale)
                {
                    case 1:
                        for (int i = 0; i < Ingredients.IngredientQuantitiesList.Count; i++)
                        {
                            Ingredients.IngredientQuantitiesList[i][0] = (int)(Ingredients.IngredientQuantitiesList[i][0] / halfScale);
                            Console.WriteLine("Quantity: " + Ingredients.IngredientQuantitiesList[i][0]);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You have successfully reset the quantity!");
                        }
                        break;
                    case 2:
                        for (int i = 0; i < Ingredients.IngredientQuantitiesList.Count; i++)
                        {
                            Ingredients.IngredientQuantitiesList[i][0] = (int)(Ingredients.IngredientQuantitiesList[i][0] / doubleScale);
                            Console.WriteLine("Quantity: " + Ingredients.IngredientQuantitiesList[i][0]);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You have successfully reset the quantity!");
                        }
                        break;
                    case 3:
                        for (int i = 0; i < Ingredients.IngredientQuantitiesList.Count; i++)
                        {
                            Ingredients.IngredientQuantitiesList[i][0] = (int)(Ingredients.IngredientQuantitiesList[i][0] / trippleScale);
                            Console.WriteLine("Quantity: " + Ingredients.IngredientQuantitiesList[i][0]);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You have successfully reset the quantity!");
                        }
                        break;
                }
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartOne
{
    // A static class to store global variables
    class Global
    {
        // Strings to hold different messages
        public static string Fullrecipe, DisplayingRecipe, ScaledIngredientQuantities, QuantitiesReset, ClearData, ExitProgram;

        // Integer to hold the user's choice in the main menu
        public static int MainMenuOption = 0;
    }

    // The main program
    internal class Program
    {
        // The entry point of the program
        static void Main(string[] args)
        {
            // A welcome message, welcoming users
            Console.WriteLine("Welcome to Recipe World\n");

            // Call the main menu function
            MainMenu();
        }

        // A function to display the main menu
        public static void MainMenu()
        {
            // Create a new instance of the Ingredients class
            Ingredients myRecipe = new Ingredients();

            // A do-while loop to keep running the program until the user chooses to exit
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("*********************************");
                Console.WriteLine("             Menu \n");

                // A main menu for the console app, prompting the user to input an option.
                Console.Write("1. Enter a recipe\n" +
                    "2. Display the full recipe \n" +
                    "3. Change the quantity scaled \n" +
                    "4. Reset the quantity scaled \n" +
                    "5. Clear all data \n" +
                    "6. Exit program \n\n" +
                    "Select an option: ");

                

                try
                {
                    // Try to convert the user's input to an integer and store it in MainMenuOption
                    Global.MainMenuOption = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    // If the user input cannot be converted to an integer, display an error message
                    Console.WriteLine("You have to input a number.");
                }

                Console.WriteLine("*********************************");

                switch (Global.MainMenuOption)
                {
                    case 1:

                        // Call the InputtingIngredients function of the Ingredients class to let the user input a recipe
                        Ingredients.InputtingIngredients();
                        break;

                    case 2:
                        if (myRecipe.NumOfIngri > 0)
                        {
                            // Call the DisplayingMenu function of the Ingredients class to display the recipe
                            Ingredients.DisplayingMenu();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            // If there is no recipe, display an error message and return to the main menu
                            Console.WriteLine("You need to input a recipe");
                            MainMenu();
                        }

                        break;
                    case 3:

                        if (myRecipe.NumOfIngri > 0)
                        {
                            // Call the changingScaledQuantity function of the ScaledQuantity class to let the user change the scaled quantity of an ingredient
                            ScaledQuantity.changingScaledQuantity();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            // If there is no recipe, display an error message and return to the main menu
                            Console.WriteLine("You need to input a recipe");
                            MainMenu();
                        }

                        break;
                    case 4:

                        ScaledQuantity myScaleObj = new ScaledQuantity();

                        if (myRecipe.NumOfIngri > 0 && myScaleObj.OptionScale > 0)
                        {
                            // Call the resettingScaledQuantity function of the ScaledQuantity class to reset the scaled quantity of all ingredients
                            ScaledQuantity.resettingScaledQuantity();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            // If there is no recipe, display an error message and return to the main menu
                            Console.WriteLine("You need to input a recipe or change the scale of the quantity!");
                            MainMenu();
                        }

                        
                        break;
                    case 5:

                        if (myRecipe.NumOfIngri > 0)
                        {
                            // Call the ClearingData function of the Ingredients class to clear all data and start inputting a new recipe
                            Ingredients.ClearingData();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            // If there is no recipe, display an error message and return to the main menu
                            Console.WriteLine("You need to input a recipe");
                            MainMenu();
                        }

                        
                        
                        break;
                    case 6:
                        // Exit the program
                        Environment.Exit(0);
                        break;
                    default:
                        // If the user enters an invalid option, display an error message
                        if (Global.MainMenuOption > 6)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You have inputted a number greater than 6, try again! \n");
                        }
                        break;
                }
            } while (Global.MainMenuOption != 6);
        }
    }
}

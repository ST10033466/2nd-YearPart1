using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartTwo
{
    internal class RecipeApp
    {
        static void Main(string[] args)
        {
            // A welcome message, welcoming users
            Console.WriteLine("Welcome to Recipe World\n");

            // Call the main menu function
            MainMenu();
        }

        public static void MainMenu()
        {
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
                    int mainMenuOption = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("*********************************");

                    switch (mainMenuOption)
                    {
                        case 1:
                            // Option 1: Enter a recipe
                            Ingredients.InputtingIngredients();
                            break;

                        case 2:
                            // Option 2: Display the full recipe
                            if (Ingredients.IngredientNamesList.Count > 0)
                            {
                                Ingredients.DisplayRecipeList();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You need to input a recipe");
                                MainMenu();
                            }
                            break;

                        case 3:
                            // Option 3: Change the quantity scaled
                            if (Ingredients.IngredientNamesList.Count > 0)
                            {
                                ScaledQuantity.ChangingScaledQuantity();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You need to input a recipe");
                                MainMenu();
                            }
                            break;

                        case 4:
                            // Option 4: Reset the quantity scaled
                            if (Ingredients.IngredientNamesList.Count > 0 && ScaledQuantity.OptionScale > 0)
                            {
                                ScaledQuantity.ResettingScaledQuantity();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You need to input a recipe or change the scale of the quantity!");
                                MainMenu();
                            }
                            break;

                        case 5:
                            // Option 5: Clear all data
                            if (Ingredients.IngredientNamesList.Count > 0)
                            {
                                Ingredients.ClearData();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You need to input a recipe");
                                MainMenu();
                            }
                            break;

                        case 6:
                            // Option 6: Exit program
                            Environment.Exit(0);
                            break;

                        default:
                            // Invalid option
                            if (mainMenuOption > 6)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You have inputted a number greater than 6, try again! \n");
                            }
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have to input a number.");
                }
            } while (true);
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartOne
{
    class Global
    {
        //public static string recipe, displayRecipe, scaledRecipe, reset, clear, exitProgram;

        public static int mainMenuOption = 0;
    }



    internal class Program
    {
        static void Main(string[] args)
        {

            //A welcome message, welcoming users
            Console.WriteLine("Welcome to Recipe World\n");

            Menu();




        }
            public static void Menu()
        {
            //A do while loop create so the program can run untill the user exits the program
            do
            {
                //A  main menu for the console app, promting the user to input an option.
                Console.WriteLine("Select an option\n" +
                    "1. Enter a recipe\n" +
                    "2. Display the full recipe\n" +
                    "3. Change the quantity scaled\n" +
                    "4. Reset the quantity scaled\n" +
                    "5. Clear all data\n" +
                    "6. Exit program");
                Global.mainMenuOption = Convert.ToInt32(Console.ReadLine());

                Recipe myRecipe = new Recipe();

           //     int len= myRecipe.Name.Length;

                //If statement create to perform the actions of selected from the main menu option
                if (Global.mainMenuOption == 1)
                {

                    //Calling the obect of the recipe class so it can perform the functions of the class.
                    Recipe.ingredients();

                }
                else if (Global.mainMenuOption == 2)
                {
                    Recipe.DisplayMenu();

                    Recipe.ingredients();

                    //if (len.Equals(0))
                    //{
                    //    Console.WriteLine("You have not entered a recipe");

                    //}
                    //else { Recipe.DisplayMenu(); }


                }
                else if (Global.mainMenuOption == 3)
                {

                }
                else if (Global.mainMenuOption == 4)
                {

                }
                else if (Global.mainMenuOption == 5)
                {

                }
                else if (Global.mainMenuOption == 6)
                {

                }


            } while (Global.mainMenuOption > 6);

            Console.ReadKey();
        }
    }
    
}

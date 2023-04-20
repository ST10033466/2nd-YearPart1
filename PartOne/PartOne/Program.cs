﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartOne
{
    class Global
    {
        public static string Fullrecipe, DisplayingRecipe, ScaledIngredientQuantities, QuantitiesReset, ClearData, ExitProgram;

        public static int MainMenuOption = 0;
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

            Recipe myRecipe = new Recipe();

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


                try
                {
                    Global.MainMenuOption = Convert.ToInt32(Console.ReadLine());
                }

                catch (Exception e)
                {

                    Console.WriteLine("You have inputed a wrong option.");

                }



                switch (Global.MainMenuOption)
                {
                    case 1:

                        //Calling the obect of the recipe class so it can perform the functions of the class.
                        Recipe.ingredients();
                        break;

                    case 2:

                        if (Recipe.NumOfIngri != 0)
                        {
                            Recipe.DisplayMenu();
                        }
                        else
                        {
                            Console.WriteLine("You need to input a recipe");
                            Menu();
                        }
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                }



            } while (Global.MainMenuOption != 6);

            Console.ReadKey();
        }
    }

}

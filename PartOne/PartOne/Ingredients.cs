using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartOne
{
    internal class Ingredients
    {

        // These static variables will store the data entered by the user.
        private static int numOfIngri, numOfSteps;
        private static int[] ingridentQuantity;
        private static string[] ingredientName;
        private static string[] unitOfMeasurement;
        private static string[] descriptionOfSteps;

        // These properties allow external code to access and modify the static variables.
        public int[] Quantity 
        { get {return ingridentQuantity; }
            set {ingridentQuantity = value; } 
        }

        public string[] Name
        {
            get { return ingredientName; }
            set { ingredientName = value; }
        }

        public string[] Unit
        {
            get { return unitOfMeasurement; }
            set { unitOfMeasurement = value; }
        }


        public string[] Description
        {
            get { return descriptionOfSteps; }
            set { descriptionOfSteps = value; }
        }


        public int NumOfIngri
        {
            get { return numOfIngri; }
            set { numOfIngri = value; }
        }


        public int NumOfSteps
        {
            get { return numOfSteps; }
            set { numOfSteps = value; }
        }




        // This method prompts the user to input the ingredient details and stores them in the static variables.
        public static void InputtingIngredients()
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nHow many Ingridents would you like to add: ");

            
            while (true)
            {
                try
                {
                    numOfIngri = Convert.ToInt32(Console.ReadLine());
                    break;  // exit the loop if the input is valid
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Wrong input, Please input a number:  ");
                }
            }




            ingridentQuantity = new int[numOfIngri];
            ingredientName = new string[numOfIngri];
            unitOfMeasurement = new string[numOfIngri];


            for (int i = 0; numOfIngri > i; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("What is the name of ingridents " + (i + 1) + ": ");
                ingredientName[i] = Console.ReadLine();



                Console.Write("What is the qunatity of ingridents " + (i + 1) + ": ");

                while (true)
                {
                    try
                    {
                        ingridentQuantity[i] = Convert.ToInt32(Console.ReadLine());
                        break; // exit the loop if the input is valid
                    }
                    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Wrong input, Please input a number:  ");
                    }
                }


                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("What is the unit of measurement of ingridents " + (i + 1) + ": ");
                unitOfMeasurement[i] = Console.ReadLine();



            }

            Console.Write("How many steps are there: ");

            while (true)
            {
                try
                {
                    numOfSteps = Convert.ToInt32(Console.ReadLine());
                    break; // exit the loop if input is valid
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Wrong input, Please input a number:  ");
                }
            }



            descriptionOfSteps = new string[numOfSteps];

            for (int i = 0; numOfSteps > i; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Step " + (i + 1) + ": ");
                descriptionOfSteps[i] = Console.ReadLine();

            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nYou have entered the details successfully");

            // Calls the MainMenu method in the Program class to go back to the main menu.
            Program.MainMenu();

            Console.ReadKey();

        }

        // This method displays the ingredients and steps entered by the user.
        public static void DisplayingMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            // creating an object of the ScaledQuantity class
            ScaledQuantity myobj = new ScaledQuantity();

            // printing the header and ingredients section of the recipe
            Console.WriteLine("*********************************");
            Console.WriteLine("        Recipe Dispaly \n");    
            Console.WriteLine("Ingredients:");
            Console.WriteLine("*********************************");
            Console.WriteLine("Number of Ingredients: " + numOfIngri + "\n");
            for (int j = 0; ingredientName.Length > j ; j++)
            {

                Console.WriteLine("Name of Ingredient: " + ingredientName[j]);
                Console.WriteLine("Quantity of Ingredient: " + ingridentQuantity[j]);
                Console.WriteLine("Unit of Measurement: " + unitOfMeasurement[j] + "\n");
            }

            // printing the steps section of the recipe
            Console.WriteLine("             Steps \n");
            for (int k = 0; numOfSteps > k; k++)
            {
                Console.WriteLine("Step " + (k + 1) + ": " + descriptionOfSteps[k]);
            }
            Console.WriteLine("*********************************");



        }

        // This method clears the data from the recipe
        public static void ClearingData() 
        {
            Console.ForegroundColor = ConsoleColor.White;
            // variable that stores the user's confirmation to clear the data
            int confirmationOFClearing = 0;

            // prompting user to confirm if they want to clear the data or not
            do
            {
                Console.Write("Would you like to clear the data: \n" +
                    "1. Yes \n" +
                    "2. No \n" +
                    "Enter your option: ");

                // using try-catch to handle incorrect user input
                try
                {
                    // storing user input for confirmation
                    confirmationOFClearing = Convert.ToInt32(Console.ReadLine());

                    // check if input is within valid range
                    if (confirmationOFClearing < 1 || confirmationOFClearing > 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input. Please enter 1 or 2.");
                        confirmationOFClearing = 0; // reset confirmation
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect Input, Type in a number.");
                    confirmationOFClearing = 0; // reset confirmation
                }
            } while (confirmationOFClearing == 0);




            // using a switch statement to handle the user's choice
            switch (confirmationOFClearing)
            {

                // if the user chooses to clear the data, all the recipe data is reset to null or 0
                case 1:

                    numOfIngri = 0;
                    numOfSteps = 0;
                    ingridentQuantity = null;
                    ingredientName = null;
                    unitOfMeasurement = null;
                    descriptionOfSteps = null;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You have cleared!");

                    //Calling InputtingIngredients method to prompt user to input data after clearing
                    Ingredients.InputtingIngredients();

                    break;

                // if the user chooses not to clear the data, a message is printed indicating their choice
                //The option will take the user back to the Menu
                case 2:

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You have decided to not clear the data");
                    Program.MainMenu();

                    break;


            }


        
        }
    }
}

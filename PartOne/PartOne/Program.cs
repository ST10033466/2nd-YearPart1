using System;
using System.Collections.Generic;
using System.ComponentModel;
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

            
            Console.Write("\nHow many Ingridents would you like to add: ");

            try
            {
                numOfIngri = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.Write("Wrong input, Please input a number:  ");

                numOfIngri = Convert.ToInt32(Console.ReadLine());


            }




            ingridentQuantity = new int[numOfIngri];
            ingredientName = new string[numOfIngri];
            unitOfMeasurement = new string[numOfIngri];


            for (int i = 0; numOfIngri > i; i++)
            {

                Console.Write("What is the name of ingridents " + (i + 1) + ": ");
                ingredientName[i] = Console.ReadLine();



                Console.Write("What is the qunatity of ingridents " + (i + 1) + ": ");


                try
                {
                    ingridentQuantity[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.Write("Wrong input, Please input a number:  ");

                    ingridentQuantity[i] = Convert.ToInt32(Console.ReadLine());


                }

                

                Console.Write("What is the unit of measurement of ingridents " + (i + 1) + ": ");
                unitOfMeasurement[i] = Console.ReadLine();



            }

            Console.Write("How many steps are there: ");

            try
            {
                numOfSteps = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.Write("Wrong input, Please input a number:  ");

                numOfSteps = Convert.ToInt32(Console.ReadLine());


            }

            

            descriptionOfSteps = new string[numOfSteps];

            for (int i = 0; numOfSteps > i; i++)
            {
                Console.Write("Step " + (i + 1) + ": ");
                descriptionOfSteps[i] = Console.ReadLine();

            }

            Console.WriteLine("\nYou have entered the details successfully\n");

            // Calls the MainMenu method in the Program class to go back to the main menu.
            Program.MainMenu();

            Console.ReadKey();

        }

        // This method displays the ingredients and steps entered by the user.
        public static void DisplayingMenu()
        {
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
            // variable that stores the user's confirmation to clear the data
            int confirmationOFClearing = 0;

            // prompting user to confirm if they want to clear the data or not
            Console.Write("Would you like to clear the data: " +
                "1. Yes \n" +
                "2. No \n" +
                "3. Go back to menu \n" +
                "Enter your option: ");

            // using try-catch to handle incorrect user input
            try
            {
                // storing user input for confirmation
                confirmationOFClearing = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e) 
            {
                Console.Write("Incorrect Input, Type in a number: ");
            }

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

                    Console.WriteLine("You have cleared!");

                    break;

                // if the user chooses not to clear the data, a message is printed indicating their choice
                case 2:

                    Console.WriteLine("You have decided to not clear the data");

                    break;

                // if the user chooses to go back to the menu, the DisplayingMenu() method is called
                case 3:

                    Ingredients.DisplayingMenu();

                    break;

            }


        
        }
    }
}

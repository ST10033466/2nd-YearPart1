using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartOne
{
    internal class Ingredients
    {


        private static int numOfIngri, numOfSteps;
        private static int[] ingridentQuantity;
        private static string[] ingredientName;
        private static string[] unitOfMeasurement;
        private static string[] descriptionOfSteps;


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

            Program.MainMenu();

            Console.ReadKey();

        }

        public static void DisplayingMenu()
        {

            ScaledQuantity myobj = new ScaledQuantity();

            Console.WriteLine("*********************************");
            Console.WriteLine("        Recipe Dispaly \n");    
            Console.WriteLine("Ingredients:");
            Console.WriteLine("*********************************");
            Console.WriteLine("Number of Ingredients: " + numOfIngri + "\n");
            for (int j = 0; ingredientName.Length > j ; j++)
            {

                Console.WriteLine("Name of Ingredient: " + ingredientName[j]);
                Console.WriteLine("Quantity of Ingredient: " + ingridentQuantity[j]);
               
                //ScaledQuantity.resettingScaledQuantity();
                Console.WriteLine("Unit of Measurement: " + unitOfMeasurement[j] + "\n");
            }

            
            Console.WriteLine("             Steps \n");
            for (int k = 0; numOfSteps > k; k++)
            {
                Console.WriteLine("Step " + (k + 1) + ": " + descriptionOfSteps[k]);
            }
            Console.WriteLine("*********************************");



        }

        public static void ClearingData() 
        {
            //This is the variable that stores the option for clearing data or not.
            int confirmationOFClearing = 0;

            Console.Write("Would you like to clear the data: " +
                "1. Yes \n" +
                "2. No \n" +
                "3. Go back to menu \n" +
                "Enter your option: ");

            //Try and catch used so that the program can pick up if the user made an incorrect input
            //and re-prompt them.
            try 
            {
                //Stroing user input for the 
                confirmationOFClearing = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e) 
            {
                Console.Write("Incorrect Input, Type in a number: ");
            }


            switch(confirmationOFClearing)
            {
                case 1:

                    numOfIngri = 0;
                    numOfSteps = 0;
                    ingridentQuantity = null;
                    ingredientName = null;
                    unitOfMeasurement = null;
                    descriptionOfSteps = null;

                    Console.WriteLine("You have cleared!");

                    break;
                case 2:

                    Console.WriteLine("You have decided to not clear the data");

                    break;
                case 3:

                    Ingredients.DisplayingMenu();

                    break;

            }


        
        }
    }
}

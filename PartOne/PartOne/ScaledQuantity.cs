using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartOne
{
    internal class ScaledQuantity
    {

        // Declare a static instance of Ingredients
        public static Ingredients myIngri = new Ingredients();

        // Declare an integer variable to store the option of scale
        private static int optionOfScale = 0;

        public int OptionScale
        {
            get { return optionOfScale; }
            set { optionOfScale = value; }
        }

        public static double halfScale = 0.5;
        public static double doubleScale = 2;
        public static double trippleScale = 3;


        // Create a static method to change the scaled quantity
        public static void changingScaledQuantity()
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
                        "3. Tripple \n" +
                        "Input option: ");

                    try
                    {
                        optionOfScale = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("You made an incorrect input, Please try again");
                        optionOfScale = 0; // set to 0 to keep the loop running
                    }

                } while (optionOfScale < 1 || optionOfScale > 3); // keep looping until user input is correct



                // Use a switch statement to perform different actions based on the user's input
                switch (optionOfScale)
                {
                    case 1:
                        // Use a for loop to iterate through the ingredients and update their quantities to half
                        for (int i = 0; i < myIngri.NumOfIngri ; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            myIngri.Quantity[i] = (int)(myIngri.Quantity[i] * halfScale);

                            Console.WriteLine("Quantity " + (i + 1) + ": " + myIngri.Quantity[i]);

                        }

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have successfully changed the qunatity to half.");

                        break;
                    case 2:

                        // Use a for loop to iterate through the ingredients and update their quantities to double
                        for (int i = 0; i < myIngri.NumOfIngri ; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            myIngri.Quantity[i] = (int)(myIngri.Quantity[i] * doubleScale);

                            Console.WriteLine("Quantity " + (i + 1) + ": " + myIngri.Quantity[i]);

                        }

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have successfully changed the qunatity to double.");
                        break;
                    case 3:

                        // Use a for loop to iterate through the ingredients and update their quantities to triple
                        for (int i = 0; i < myIngri.NumOfIngri; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            myIngri.Quantity[i] = (int)(myIngri.Quantity[i] * trippleScale);

                            Console.WriteLine("Quantity " + (i + 1) +": "+ myIngri.Quantity[i]);

                        }

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have successfully changed the qunatity to tripple.");
                        break;
                    
                }

                // Call the MainMenu() method of the Program class to return to the main menu
                Program.MainMenu();

            }

        }

        // Create a static method to reset the scaled quantity
        public static void resettingScaledQuantity() 
      
  {
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Use a for loop to iterate through the ingredients and update their quantities to half
            for (int j = 0; j < myIngri.NumOfIngri; j++) 
            {
                //Using a switch statement to check option used to 
                switch (optionOfScale) 
                {
                    case 1:

                        for (int i = 0; i < myIngri.NumOfIngri; i++)
                        {
                            myIngri.Quantity[j] = (int)(myIngri.Quantity[j] / halfScale);

                            Console.WriteLine("Quantity: " + myIngri.Quantity[i] );
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You have succesfully reset the quantity!");

                        }

                        
                        break;
                    case 2:

                        for (int i = 0; i < myIngri.NumOfIngri; i++)
                        {
                            myIngri.Quantity[j] = (int)(myIngri.Quantity[j] / doubleScale);

                            Console.WriteLine("Quantity: " + myIngri.Quantity[i]);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You have succesfully reset the quantity!");

                        }

                        
                        break;
                    case 3:

                        for (int i = 0; i < myIngri.NumOfIngri; i++)
                        {
                            myIngri.Quantity[j] = (int)(myIngri.Quantity[j] / trippleScale);

                            Console.WriteLine("Quantity: " + myIngri.Quantity[i]);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You have succesfully reset the quantity!");

                        }

                        
                        break;
                }
                

            }


        }
    }
}

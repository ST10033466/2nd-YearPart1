using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartOne
{
    internal class ScaledQuantity
    {
        public static Ingredients myIngri = new Ingredients();

        public static int optionOfScale = 0;

        private static int[] newQuantity = new int[myIngri.NumOfIngri];

        public int[] NewQuantity
        {
            get { return newQuantity; }
            set { newQuantity = value; }
        }

        

        public static void changingScaledQuantity()
        {


            while (optionOfScale < 3) 
            {
                Console.Write("What scale would you like to change the quantity to: \n" +
                "1. Half \n" +
                "2. Double \n" +
                "3. Tripple \n" +
                "4. Go back to Main Menu \n" +
                "5. Exit Program \n" +
                "Input option: ");


                try
                {
                    optionOfScale = Convert.ToInt32(Console.ReadLine());  
                }
                catch (Exception e)
                {
                    Console.Write("You made an incorrect input, Please try again: ");
                }

                switch (optionOfScale)
                {
                    case 1:

                        for(int i = 0; i < myIngri.NumOfIngri ; i++)
                        {
                            myIngri.Quantity[i] *= (int)0.5;

                            Console.WriteLine("Quantity: " + myIngri.Quantity[i]);

                        }

                        Console.WriteLine("You have successfully changed the qunatity to half.");

                        break;
                    case 2:
                        for (int i = 0; i < myIngri.NumOfIngri ; i++)
                        {
                            myIngri.Quantity[i] *= 2;

                            Console.WriteLine("Quantity: " + myIngri.Quantity[i]);

                        }

                        Console.WriteLine("You have successfully changed the qunatity to double.");
                        break;
                    case 3:
                        for (int i = 0; i < myIngri.NumOfIngri; i++)
                        {
                            myIngri.Quantity[i] *= 3;

                            Console.WriteLine("Quantity: " + myIngri.Quantity[i]);

                        }

                        Console.WriteLine("You have successfully changed the qunatity to tripple.");
                        break;
                    case 4:
                        Program.MainMenu();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }

            }

        }

        public static void resettingScaledQuantity() 
        {
            for (int j = 0; j < myIngri.NumOfIngri; j++) 
            {
               
                        myIngri.Quantity[j] /= 2;
                        //myIngri.Quantity[j] = (int)0.5 / myIngri.Quantity[j];
                        //myIngri.Quantity[j] /= 3;





            }
                

        }
    }
}

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

        private static int[] newQuantity = new int[myIngri.NumOfIngri];

        public int[] NewQuantity
        {
            get { return newQuantity; }
            set { newQuantity = value; }
        }

        

        public static void changingScaledQuantity()
        {
            

            double halfScaled = 0.5;
            int doubleScaled = 2;
            int trippleScaled = 3;
            int optionOfScale = 0;

            newQuantity = myIngri.Quantity;
            //int[] newQuantity = new int[myIngri.NumOfIngri];



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

                int[] scaledQuantity = new int[myIngri.NumOfIngri];

                switch (optionOfScale)
                {
                    case 1:

                        for(int i = 0; i < myIngri.NumOfIngri ; i++)
                        {
                            newQuantity[i] *= (int)halfScaled;

                            Console.WriteLine("Quantity: " + myIngri.Quantity[i]);

                        }

                        Console.WriteLine("You have successfully changed the qunatity to half.");

                        //for (int i = 0; i < myIngri.Quantity.Length; i++)
                        //{
                        //    myIngri.Quantity[i] *= (int)Scale[optionOfScale];
                        //}



                        break;
                    case 2:
                        for (int i = 0; i < myIngri.NumOfIngri ; i++)
                        {
                            newQuantity[i] *= doubleScaled;

                            Console.WriteLine("Quantity: " + myIngri.Quantity[i]);

                        }

                        Console.WriteLine("You have successfully changed the qunatity to double.");
                        break;
                    case 3:
                        for (int i = 0; i < myIngri.NumOfIngri; i++)
                        {
                            newQuantity[i] *= trippleScaled;

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



                if (myIngri.Quantity[j] > newQuantity[j])
                {
                    Console.WriteLine(" Old Quantity: " + myIngri.Quantity[j]);
                    Console.WriteLine(" New Quantity: " + newQuantity[j]);
                    newQuantity[j] = myIngri.Quantity[j];
                }
                else
                {
                    Console.WriteLine(" The Quantity: " + newQuantity[j]);
                }
            }
                

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartOne
{
    internal class Recipe
    {

        public int[] Quantity { get; set; }

        public string[] Name { get; set; } 

        public string[] Unit { get; set; }


        public string[] Description { get; set; }


        public int NumOfIngri { get; set; }


        public int NumOfSteps { get; set; }



        

        public static void ingredients()
        {
            Recipe theRecipe = new Recipe();

            Console.WriteLine("How many Ingridents would you like to add?");

            try
            {
                theRecipe.NumOfIngri = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.Write("Wrong input, Please input a number:  ");

                theRecipe.NumOfIngri = Convert.ToInt32(Console.ReadLine());
                
                
            }




            theRecipe.Quantity = new int[theRecipe.NumOfIngri];
            theRecipe.Name = new string[theRecipe.NumOfIngri];
            theRecipe.Unit = new string[theRecipe.NumOfIngri];


            for (int i = 0; theRecipe.NumOfIngri > i; i++)
            {

                Console.WriteLine("What is the name of ingridents " + (i + 1) + " ?");
                theRecipe.Name[i] = Console.ReadLine();



                Console.WriteLine("What is the qunatity of ingridents " + (i + 1) + " ?");
                theRecipe.Quantity[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the unit of measurement of ingridents " + (i + 1) + " ?");
                theRecipe.Unit[i] = Console.ReadLine();



            }

            Console.WriteLine("How many steps are there? ");
            theRecipe.NumOfSteps = Convert.ToInt32(Console.ReadLine());

            theRecipe.Description = new string[theRecipe.NumOfSteps];

            for (int i = 0; theRecipe.NumOfSteps > i; i++)
            {
                Console.WriteLine("Step " + (i + 1));
                theRecipe.Description[i] = Console.ReadLine();

            }

            Console.WriteLine("You have entered the details successfully\n");

            Program.Menu();

            Console.ReadKey();

        }

        public static void DisplayMenu(Recipe theRecipe)
        {
            

            Console.WriteLine("Recipe: ");
            Console.WriteLine("*************************\n");

            Console.WriteLine("Ingredients");
            Console.WriteLine("************************");
            Console.WriteLine("Number of Ingredients: " + theRecipe.NumOfIngri);
            for (int j = 0; theRecipe.NumOfIngri > j; j++)
            {

                Console.WriteLine("Name of Ingredient: " + theRecipe.Name[j]);
                Console.WriteLine("Quantity of Ingredient: " + theRecipe.Quantity[j]);
                Console.WriteLine("Unit of Measurement: " + theRecipe.Unit[j]);
            }

            Console.WriteLine("************************************");
            Console.WriteLine("Step: " + theRecipe.NumOfSteps);
            for (int k = 0; theRecipe.NumOfSteps > k; k++)
            {
                Console.WriteLine("Step " + (k + 1) + ": " + theRecipe.Description[k]);
            }


            Console.ReadKey();



        }
    }
}

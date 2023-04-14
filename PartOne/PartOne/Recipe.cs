using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartOne
{
    internal class Recipe
    {
        class Global {

            public static int numOfIngri;
            public static int numOfSteps;
            
        }

        private static string[] nameIngri;
        private static string[] unitOfMeasure;
        private static string[] descripSteps;

        public static int[] Quantity { get; set; }

        public string[] Name { 
            get { return nameIngri; } 
            set { nameIngri = value; } }

        public Recipe(string[] nameIngri, string[] unitOfMeasure, string[] descripSteps)
        {
            Name = nameIngri;
            Unit = unitOfMeasure;
            Description = descripSteps;
        }

        public Recipe()
        {
        }

        public string[] Unit {
            get { return unitOfMeasure; }
            set { unitOfMeasure = value; } }
            

        public string[] Description {
            get { return descripSteps; } 
            set { descripSteps = value; } }




        public static void ingredients()
        {
            Console.WriteLine("How many Ingridents would you like to add?");
            Global.numOfIngri = Convert.ToInt32(Console.ReadLine());


            Quantity = new int[Global.numOfIngri];
            nameIngri = new string[Global.numOfIngri];
            unitOfMeasure = new string[Global.numOfIngri];
            

            for (int i = 0; Global.numOfIngri > i; i++)
            {

                Console.WriteLine("What is the name of ingridents " + (i + 1) + " ?");
                nameIngri[i] = Console.ReadLine();



                Console.WriteLine("What is the qunatity of ingridents " + (i + 1) + " ?");
                Quantity[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the unit of measurement of ingridents " + (i + 1) + " ?");
                unitOfMeasure[i] = Console.ReadLine();



            }

            Console.WriteLine("How many steps are there? ");
            Global.numOfSteps = Convert.ToInt32(Console.ReadLine());

            descripSteps = new string[Global.numOfSteps];

            for (int i = 0; Global.numOfSteps > i; i++)
            {
                Console.WriteLine("Step " + (i + 1));
                descripSteps[i] = Console.ReadLine();

            }

            Console.WriteLine("You have entered the details successfully\n");

            Program.Menu();

            Console.ReadKey();

        }

        public static void DisplayMenu()
        {
            Console.WriteLine("Recipe: ");
            Console.WriteLine("*************************\n");

            Console.WriteLine("Ingredients");
            Console.WriteLine("************************");
            Console.WriteLine("Number of Ingredients: " + Global.numOfIngri);
            for (int j = 0; Global.numOfIngri > j; j++)
            {
                
                Console.WriteLine("Name of Ingredient: " + nameIngri[j]);
                Console.WriteLine("Quantity of Ingredient: " + Quantity[j]);
                Console.WriteLine("Unit of Measurement: "+ unitOfMeasure[j]);
            }

            Console.WriteLine("************************************");
            Console.WriteLine("Step: "+ Global.numOfSteps);
            for (int k = 0; Global.numOfSteps > k; k++)
            {
                Console.WriteLine("Step " + (k+1)+": "+ descripSteps[k]);
            }
            

            Console.ReadKey();



        }
    }
}

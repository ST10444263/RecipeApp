using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Recipe App");
            Recipe recipe = new Recipe();

            // Get the number of ingrediants
            Console.WriteLine("Enter the number of ingrediants: ");
            int ingredientsCount = int.Parse(Console.ReadLine());
            recipe.Ingredients = new List<Ingredient>();

            for (int i = 0; i < ingredientsCount; i++)
            {
                Console.WriteLine($"Entering ingredient {i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Quantity: ");
                double quantity = double.Parse(Console.ReadLine());
                Console.Write("Unit of measurement: ");
                string unit = Console.ReadLine();

                recipe.Ingredients.Add(new Ingredient(name, quantity, unit));   
            }

            // Get number of steps
            Console.Write("Enter the number of steps: ");
            int stepCount = int.Parse(Console.ReadLine());
            recipe.Steps = new List<string>();

            for (int i = 0; i < stepCount; i++)
            {
                Console.WriteLine($"Enter step {i + 1}: ");
                Console.Write("Description: ");
                string stepDescription = Console.ReadLine();
                recipe.Steps.Add(stepDescription);
            }

            //Display the recipe
            Console.WriteLine("\nYour Recipe:");
            recipe.DisplayRecipe();
        }
    }

    class Ingredient        // Class of all the needed ingredients
    {
        public string Name { get; }
        public double Quantity { get; }
        public string Unit { get; }

        public Ingredient(string name, double quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
        }

        public override string ToString()
        {
            return $"{Quantity} {Unit} of {Name}";
        }
    }

    class Recipe        // Class of all Listed ingredients and steps
    {
        public List<Ingredient> Ingredients { get; set; }
        public List<string> Steps { get; set; }

        public void DisplayRecipe()
        {
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine($"- {Ingredients}");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < Steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i]}");
            }
        }
    }
}

using System;

namespace FunctionsReturnAndArraysFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "KFC", "sushi", "chinese", "tacos", "salad" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);

            string RandomFood = foods[randomIndex];
            Console.WriteLine($"Computer picked: {RandomFood}");
        }

        private static void DisplayRandomDrink()
        {
            string[] drinks = { "orange juice", "water", "Fanta", "Sprite" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, drinks.Length);

            string RandomDrink = drinks[randomIndex];
            Console.WriteLine($"Computer picked: {RandomDrink}");
        }

        private static void DisplayRandomMovie()
        {
            string[] movies = { "Interstellar", "Expandables", "Safe House", "Insidious", "Eat Pray Love", "The Ritual", "Miracle in Cell NO.7" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, movies.Length);

            string RandomMovie = movies[randomIndex];
            Console.WriteLine($"Computer picked: {RandomMovie}");
        }
    }
}

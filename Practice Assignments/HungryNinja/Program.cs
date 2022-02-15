using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Food
    {
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;
        public Food(string name, int calories, bool sweet, bool spicy)
        {
            Name = name;
            Calories = calories;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }
    
    class Buffet
    {
        public List<Food> Menu;
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Pizza", 800, false, false),
                new Food("Spaghetti", 850, false, false),
                new Food("Tacos", 750, true, false),
                new Food("Sushi", 800, false, false),
                new Food("Chili", 800, true, false),
                new Food("Omellette", 900, false, false),
                new Food("PHO", 800, false, false),
            };
        }
        public Food serve()
        {
            Random r = new Random();
            return Menu[r.Next(Menu.Count)];
        }
    }
    class Ninja
    {
        private int caloriesEaten;

        public List<Food> History;

        public Ninja()

        {

            caloriesEaten = 0;

            History = new List<Food>();

        }

        public bool IsFull

        {

            get

            {

                return caloriesEaten > 1200;

            }

        }

        public bool Eat(Food meal)

        {

            if(!IsFull)

            {

                caloriesEaten += meal.Calories;

                History.Add(meal);

                Console.WriteLine($"Ninja digs in to some delicious {meal.Name}");

            }

            else

                Console.WriteLine("Ninja is too full to eat!");



            return IsFull;

        }

    }
}

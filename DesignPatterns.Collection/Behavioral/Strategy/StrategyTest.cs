using DesignPatterns.Behavioral.Strategy.Context;
using DesignPatterns.Behavioral.Strategy.Strategy;
using DesignPatterns.Structural.Facade.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy
{
    public class StrategyTest
    {
        public static void Execute()
        {
            CookingMethod cookMethod = new CookingMethod();

            Console.WriteLine("What food would you like to cook?\n");
            var food = Console.ReadLine();
            cookMethod.SetFood(food);

            Console.WriteLine("\nWhat cooking strategy would you like to use?\n");
            Console.WriteLine("1 - Grilling");
            Console.WriteLine("2 - Oven baking");
            Console.WriteLine("3 - Deep frying");

            int input = int.Parse(Console.ReadKey().KeyChar.ToString());

            switch (input)
            {
                case 1:
                    cookMethod.SetCookStrategy(new Grilling());
                    cookMethod.Cook();
                    break;

                case 2:
                    cookMethod.SetCookStrategy(new OvenBaking());
                    cookMethod.Cook();
                    break;

                case 3:
                    cookMethod.SetCookStrategy(new DeepFrying());
                    cookMethod.Cook();
                    break;

                default:
                    Console.WriteLine("Invalid Selection!");
                    Execute();
                    break;
            }

            Console.ReadKey();
        }
    }
}

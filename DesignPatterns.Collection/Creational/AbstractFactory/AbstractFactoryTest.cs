using DesignPatterns.Creational.AbstractFactory.Factories.Abstract;
using DesignPatterns.Creational.AbstractFactory.Factories.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    /// <summary>
    /// This class was designed to demonstrate 
    /// the usage of AbstractFactory pattern
    /// </summary>
    public class AbstractFactoryTest
    {
        public static void Execute()
        {
            Console.WriteLine("\nWho are you? (A)dult or (C)hild?");
            char input = Console.ReadKey().KeyChar;
            RecipeFactory factory;
            switch (Char.ToUpper(input))
            {
                case 'A':
                    factory = new AdultCuisineFactory();
                    break;

                case 'C':
                    factory = new KidCuisineFactory();
                    break;

                default:
                    throw new NotImplementedException();
            }

            var sandwich = factory.CreateSandwich();
            var dessert = factory.CreateDessert();

            Console.WriteLine("\nSandwich: " + sandwich.GetType().Name);
            Console.WriteLine("Dessert: " + dessert.GetType().Name);
            Console.ReadKey();
        }
    }
}

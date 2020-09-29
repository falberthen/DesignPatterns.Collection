using DesignPatterns.Creational.AbstractFactory.Factories.Abstract;
using DesignPatterns.Creational.AbstractFactory.Products.Abstract;
using DesignPatterns.Creational.AbstractFactory.Products.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory.Factories.Concrete
{
    public class AdultCuisineFactory : RecipeFactory
    {
        public override Dessert CreateDessert()
        {
            return new CremeBrulee();
        }

        public override Sandwich CreateSandwich()
        {
            return new BLT();
        }
    }
}

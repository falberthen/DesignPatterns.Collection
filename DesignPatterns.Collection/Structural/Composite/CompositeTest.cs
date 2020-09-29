using DesignPatterns.Structural.Composite.Component;
using DesignPatterns.Structural.Composite.Composite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Composite
{
    public class CompositeTest
    {
        public static void Execute()
        {
            // Continent
            var continent = new Continent("North America");

            // Countries
            var canada = new Country("Canada");
            var usa = new Country("United States");

            // Provinces
            var quebec = new State("Quebec");
            var ontario = new State("Ontario");
            var florida = new State("Florida");

            canada.AddBoundary(quebec);
            canada.AddBoundary(ontario);
            usa.AddBoundary(florida);

            // Cities
            quebec.AddBoundary(new City("Montreal"));
            quebec.AddBoundary(new City("Quebec City"));
            ontario.AddBoundary(new City("Toronto"));
            ontario.AddBoundary(new City("Ottawa"));
            florida.AddBoundary(new City("Orlando"));

            continent.AddBoundary(canada);
            continent.AddBoundary(usa);

            continent.DisplayChilds(2);
        }
    }
}

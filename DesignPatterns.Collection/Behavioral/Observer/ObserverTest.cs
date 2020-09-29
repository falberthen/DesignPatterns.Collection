using DesignPatterns.Behavioral.Observer.Observer;
using DesignPatterns.Behavioral.Observer.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer
{
    public class ObserverTest
    {
        public static void Execute()
        {
            var investorX = new Investor("Investor X");
            var investorY = new Investor("Investor Y");
            var investorZ = new Investor("Investor Z");

            var amazon = new AmazonStock("Amazon", NextDouble());
            var microsoft = new MicrosoftStock("Microsoft", NextDouble());

            amazon.Attach(investorX);
            amazon.Attach(investorY);

            microsoft.Attach(investorY);
            microsoft.Attach(investorZ);

            Console.WriteLine("");
            Console.WriteLine("------------------");
            Console.WriteLine("");

            for (int i = 0; i < 5; i++)
            {
                amazon.Price = NextDouble();
                microsoft.Price = NextDouble();

                if (i == 1)
                {
                    amazon.Detach(investorY);
                }
            }
        }

        public static double NextDouble()
        {
            var random = new Random();
            var r = random.Next(141421, 314160);
            return r / (double)100000.00;
        }
    }
}

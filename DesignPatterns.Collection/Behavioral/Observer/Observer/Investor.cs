using DesignPatterns.Behavioral.Observer.Subject;
using System;
/// <summary>
/// The 'ConcreteObserver' class
/// </summary>
namespace DesignPatterns.Behavioral.Observer.Observer
{
    class Investor : IInvestor

    {
        private string _name;
        private Stock _stock;

        // Constructor
        public Investor(string name)
        {
            this.Name = name;
        }

        public void Update(Stock stock)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Notified {0} of {1}'s " +
              "change to {2:C}", Name, stock.Symbol, stock.Price);
        }

        // Gets or sets the stock
        public Stock Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        public string Name { get => _name; set => _name = value; }
    }
}
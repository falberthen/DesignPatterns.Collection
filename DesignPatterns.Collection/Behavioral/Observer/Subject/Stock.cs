using DesignPatterns.Behavioral.Observer.Observer;
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// The 'Subject' abstract class
/// </summary>
namespace DesignPatterns.Behavioral.Observer.Subject
{
    public abstract class Stock
    {
        private string _symbol;
        private double _price;
        private List<IInvestor> _investors = new List<IInvestor>();

        // Constructor

        public Stock(string symbol, double price)
        {
            this._symbol = symbol;
            this._price = price;
        }

        public void Attach(IInvestor investor)
        {
            _investors.Add(investor);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{investor.Name} is receiving notifications from {Symbol}.");

        }

        public void Detach(IInvestor investor)
        {
            _investors.Remove(investor);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{investor.Name} is no longer receiving notifications from {Symbol}.");
        }

        public void Notify()
        {
            foreach (IInvestor investor in _investors)
            {
                investor.Update(this);
            }

            Console.WriteLine("");
        }

        // Gets or sets the price
        public double Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }

        // Gets the symbol
        public string Symbol
        {
            get { return _symbol; }
        }
    }
}
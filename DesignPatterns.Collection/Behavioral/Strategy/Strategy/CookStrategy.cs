using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy.Strategy
{
    /// <summary>
    /// The Strategy abstract class, which defines an 
    /// interface common to all supported strategy algorithms.
    /// </summary>
    public abstract class CookStrategy
    {
        public abstract void Cook(string food);
    }
}

using DesignPatterns.Structural.Composite.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Composite.Composite
{
    /// <summary>
    /// Composite class, root node
    /// </summary>
    public class Continent : Boundary, IBoundary
    {
        public Continent(string name): base(name)
        {
            Name = name;
        }
    }
}

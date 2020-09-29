using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Composite.Component
{
    /// <summary>
    /// Component class
    /// </summary>
    public abstract class Boundary : IBoundary
    {
        private readonly List<IBoundary> _children = new List<IBoundary>();

        public Boundary(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void AddBoundary(IBoundary child)
        {
            _children.Add(child);
        }

        public void DisplayChilds(int sub)
        {
            Console.WriteLine(new string('-', sub) + Name);
            _children.ForEach(child => child.DisplayChilds(sub + 2));
        }

        public IEnumerable<IBoundary> GetList()
        {
            return _children;
        }
    }
}

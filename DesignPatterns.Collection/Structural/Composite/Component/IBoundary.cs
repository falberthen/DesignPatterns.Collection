using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Composite.Component
{
    public interface IBoundary
    {
        string Name { get; set; }
        void DisplayChilds(int sub);
    }
}

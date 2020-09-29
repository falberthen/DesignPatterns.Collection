using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command
{
    /// <summary>
    /// The 'Command' abstract class
    /// </summary>
    public abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}

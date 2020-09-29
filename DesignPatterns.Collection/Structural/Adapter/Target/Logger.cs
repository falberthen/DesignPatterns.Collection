using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter.Target
{
    /// <summary>
    /// Target class
    /// </summary>
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Standard log - " + message);
        }

        public void LogError(Exception exception)
        {
            Console.WriteLine("Standard log - " + exception.Message);
        }
    }
}

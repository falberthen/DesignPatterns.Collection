using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter.Adaptee
{
    /// <summary>
    ///  Adaptee class
    /// </summary>
    public class LogDbService : IDbLogger
    {
        public void LogExceptionInDb(Exception exception)
        {
            Console.WriteLine("Logging exception into database - " + exception.Message);
        }

        public void LogInDb(string message)
        {
            Console.WriteLine("Logging into database - " + message);
        }
    }
}

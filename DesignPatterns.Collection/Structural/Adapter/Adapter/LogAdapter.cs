using DesignPatterns.Structural.Adapter.Adaptee;
using DesignPatterns.Structural.Adapter.Target;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter.Adapter
{
    /// <summary>
    /// Adapter class
    /// </summary>
    public class LogAdapter : ILogger
    {
        private readonly IDbLogger _dbLogger;

        public LogAdapter(IDbLogger dbLogger)
        {
            _dbLogger = dbLogger;
        }

        public void Log(string message)
        {
            _dbLogger.LogInDb(message);
        }

        public void LogError(Exception exception)
        {
            _dbLogger.LogExceptionInDb(exception);
        }
    }
}

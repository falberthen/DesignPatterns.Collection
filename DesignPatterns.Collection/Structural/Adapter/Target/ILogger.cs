using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter.Target
{
    /// <summary>
    /// Target interface
    /// </summary>
    public interface ILogger
    {
        void Log(string message);
        void LogError(Exception exception);
    }
}

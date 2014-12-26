using System;
using DI.Abstraction.Interfaces;

namespace DI.Abstraction.Classes
{
    public class TestLogger : ILogger
    {
        public void Log(string message)
        {
            // log message to log file
            Console.WriteLine("Log entry @ {0}: {1}", DateTime.Now.ToString("mm/dd/yyyy"), message);
        }
    }
}
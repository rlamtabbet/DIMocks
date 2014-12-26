using System;
using DI.Unitiy.Interfaces;

namespace DI.Unitiy.Classes
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            // log message to log file
            Console.WriteLine("Log entry @ {0}: {1}", DateTime.Now.ToString("mm/dd/yyyy"), message);
        }
    }
}
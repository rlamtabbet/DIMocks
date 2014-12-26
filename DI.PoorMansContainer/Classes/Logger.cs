using System;
using DI.PoorMansContainer.Interfaces;

namespace DI.PoorMansContainer.Classes
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
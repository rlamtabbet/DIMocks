using System;
using DI.StructureMap.Interfaces;

namespace DI.StructureMap.Classes
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
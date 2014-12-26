using System;
using System.ComponentModel.Composition;
using DI.MEF.Interfaces;

namespace DI.MEF.Classes
{
    [Export(typeof(ILogger))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            // log message to log file
            Console.WriteLine("Log entry @ {0}: {1}", DateTime.Now.ToString("mm/dd/yyyy"), message);
        }
    }
}
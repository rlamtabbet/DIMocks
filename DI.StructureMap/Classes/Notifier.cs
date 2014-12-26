using System;
using DI.StructureMap.Interfaces;
using DI.StructureMap;

namespace DI.StructureMap.Classes
{
    public class Notifier : INotifier
    {
        public void SendReceipt(OrderInfo orderInfo)
        {
            // send email to customer with receipt 
            Console.WriteLine("Receipt sent to customer '{0}'", orderInfo.CustomerName);
        }
    }
}

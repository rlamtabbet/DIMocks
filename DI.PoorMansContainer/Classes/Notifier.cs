using System;
using DI.PoorMansContainer.Interfaces;

namespace DI.PoorMansContainer.Classes
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

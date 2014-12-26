using System;
using DI.Unitiy.Interfaces;

namespace DI.Unitiy.Classes
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

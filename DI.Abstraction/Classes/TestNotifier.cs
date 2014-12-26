using System;
using DI.Abstraction.Interfaces;

namespace DI.Abstraction.Classes
{
    public class TestNotifier : INotifier
    {
        public void SendReceipt(OrderInfo orderInfo)
        {
            // send email to customer with receipt 
            Console.WriteLine("Receipt sent to customer '{0}'", orderInfo.CustomerName);
        }
    }
}

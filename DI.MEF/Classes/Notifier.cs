using System;
using System.ComponentModel.Composition;
using DI.MEF.Interfaces;

namespace DI.MEF.Classes
{
    [Export(typeof(INotifier))]
    [PartCreationPolicy(CreationPolicy.NonShared)] // Otherwise singleton will be used
    public class Notifier : INotifier
    {
        public void SendReceipt(OrderInfo orderInfo)
        {
            // send email to customer with receipt 
            Console.WriteLine("Receipt sent to customer '{0}'", orderInfo.CustomerName);
        }
    }
}

using System;
using DI.PoorMansContainer.Interfaces;

namespace DI.PoorMansContainer.Classes
{
    public class BillingProcessor : IBillingProcessor
    {
        public void ProcessPayment(
            string customer, string creditCard, double price)
        {
            // perform billing gatway processing
            Console.WriteLine("Payment processed for customer '{0}'", customer);
        }
    }
}
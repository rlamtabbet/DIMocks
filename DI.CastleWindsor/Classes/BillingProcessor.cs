using System;
using DI.CastleWindsor.Interfaces;

namespace DI.CastleWindsor.Classes
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
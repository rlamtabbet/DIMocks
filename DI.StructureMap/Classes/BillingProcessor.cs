using System;
using DI.StructureMap.Interfaces;

namespace DI.StructureMap.Classes
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
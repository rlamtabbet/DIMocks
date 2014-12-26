using System;
using DI.Abstraction.Interfaces;

namespace DI.Abstraction.Classes
{
    public class TestBillingProcessor : IBillingProcessor
    {
        public void ProcessPayment(
            string customer, string creditCard, double price)
        {
            // perform billing gatway processing
            Console.WriteLine("Payment processed for customer '{0}'", customer);
        }
    }
}
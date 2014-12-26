using System;

namespace DI.Coupled.Classes
{
    public class BillingProcessor
    {
        public void ProcessPayment(
            string customer, string creditCard, double price)
        {
            // perform billing gatway processing
            Console.WriteLine("Payment processed for customer '{0}'", customer);
        }
    }
}
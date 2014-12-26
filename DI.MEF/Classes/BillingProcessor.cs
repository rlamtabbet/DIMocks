using System;
using System.ComponentModel.Composition;
using DI.MEF.Interfaces;

namespace DI.MEF.Classes
{
    [Export(typeof(IBillingProcessor))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
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
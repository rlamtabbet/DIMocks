using System;
using DI.CastleWindsor.Interfaces;

namespace DI.CastleWindsor.Classes
{
    public class Customer : ICustomer
    {
        public void UpdateCustomerOrder(string customer, string product)
        {
            // update customer record with purchase
            Console.WriteLine("Customer record for '{0}' updated", customer);
        }
    }
}
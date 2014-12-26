using System;
using DI.Abstraction.Interfaces;

namespace DI.Abstraction.Classes
{
    public class TestCustomer : ICustomer
    {
        public void UpdateCustomerOrder(string customer, string product)
        {
            // update customer record with purchase
            Console.WriteLine("Customer record for '{0}' updated", customer);
        }
    }
}
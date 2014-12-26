using System;
using DI.Ninject.Interfaces;

namespace DI.Ninject.Classes
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
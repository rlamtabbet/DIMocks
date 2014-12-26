using System;
using DI.Unitiy.Interfaces;

namespace DI.Unitiy.Classes
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